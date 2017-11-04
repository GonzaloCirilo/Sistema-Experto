using SbsSW.SwiPlCs;
using SbsSW.SwiPlCs.Exceptions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T2
{
    public partial class Form1 : Form
    {
        Dictionary<String, Int32> dictionary { get; set; }
        Int32 cont = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dictionary = new Dictionary<String, Int32>();
            cmbAvenidasIni.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDistritos.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAvenidasFin.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoPasaje.DropDownStyle = ComboBoxStyle.DropDownList;
            Environment.SetEnvironmentVariable("Path", @"C:\\Program Files\\swipl\\bin");
            String[] param = { "-q", "-f", @"Trabajo2.pl" };
            PlEngine.Initialize(param);
            var Qload = new PlQuery("load('Trabajo2.bd')");
            try
            {
                Qload.NextSolution();
            }
            catch (PlException){}
            //InitializeDict();
            Query(cmbAvenidasIni, "siguiente_avenida(AV,_)", "AV");
            Query(cmbAvenidasIni, "siguiente_avenida(_,AV)", "AV");
            dictionary = new Dictionary<String, Int32>(); cont = 0;
            Query(cmbSource, "siguiente_avenida(AV,_)", "AV");
            Query(cmbSource, "siguiente_avenida(_,AV)", "AV");
            Query(cmbDistritos, "pertenece_distrito(_,Distrito)", "Distrito");
            Query(cmbTipoPasaje, "tipo_De_pasaje(Tipo,_,_)", "Tipo");
            Query(cmbTipoUser, "tipo_De_pasaje(Tipo,_,_)", "Tipo");
            dictionary = new Dictionary<String, Int32>(); cont = 0;
            Query(cmbAvenidasFin, "siguiente_avenida(AV,_)", "AV");
            Query(cmbAvenidasFin, "siguiente_avenida(_,AV)", "AV");
        }

        private void InitializeDict()
        {
            var Query = new PlQuery("siguiente_avenida(AV,_)");
            try
            {
                var cont = 0;
                foreach (var sv in Query.SolutionVariables)
                {
                    dictionary.Add(sv["AV"].ToString(), cont); cont++;
                }
            }
            catch (PlException) { }
        }

        private void Query(ComboBox cmb, String predicate, String var)
        {

            var Query = new PlQuery(predicate);
            try
            {
                
                foreach(var sv in Query.SolutionVariables)
                {
                    if (!cmb.Items.Contains(sv[var].ToString()))
                    {
                        cmb.Items.Add(sv[var].ToString());
                        if(var == "AV")
                            dictionary.Add(sv[var].ToString(), cont); cont++;
                    }
                }
            }
            catch (PlException) { }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            PlEngine.PlCleanup();
        }

        private bool Validar(List<ComboBox> lst)
        {
            foreach(var c in lst)
            {
                if (c.SelectedIndex == -1)
                {
                    MessageBox.Show("Faltan parametro(s)");
                    return false;
                }
            }
            return true;
        }

        private void btnVerParaderos_Click(object sender, EventArgs e)
        {
            if (!Validar(new List<ComboBox> { cmbDistritos })) return;
            lstbResult1.Items.Clear();
            var param = cmbDistritos.SelectedItem.ToString();
            var Query = new PlQuery("pertenece_distrito(Paraderos," + param + ")");
            try
            {
                foreach (var q in Query.SolutionVariables)
                {
                    lstbResult1.Items.Add(q["Paraderos"].ToString());
                }
            }
            catch (PlException) { }
        }

        private void btnCalcularPago_Click(object sender, EventArgs e)
        {
            Validar(new List<ComboBox> { cmbAvenidasIni, cmbAvenidasFin, cmbTipoPasaje });
            lblPago.Text = "";
            var IniNombre = cmbAvenidasIni.SelectedItem.ToString();
            var FinNombre = cmbAvenidasFin.SelectedItem.ToString();
            var TipoPasaje = cmbTipoPasaje.SelectedItem.ToString();
            var mensaje = "El trayecto  para " + TipoPasaje + " desde " + IniNombre + " hasta " + FinNombre + " cuesta: ";
            var IniIndex = dictionary[IniNombre];
            var FinIndex = dictionary[FinNombre];
            if (FinIndex < IniIndex)
            {
                var aux = IniNombre;
                IniNombre = FinNombre;
                FinNombre = aux;
            }
            var Query = new PlQuery("pagar('" + TipoPasaje + "','" + IniNombre + "','" + FinNombre + "',P)");
            try
            {
                foreach(var q in Query.SolutionVariables)
                {
                    mensaje += q["P"].ToString();
                }
            }catch (PlException) { }
            lblPago.Text = mensaje;
        }

        private void btnSee_Click(object sender, EventArgs e)
        {
            lstWhere.Items.Clear();
            if (!Validar(new List<ComboBox> { cmbSource, cmbTipoUser }) || nudRemainingMoney.Value < 0)
            { MessageBox.Show("Valor invalido"); return; }
            var SourceName = cmbSource.Text;
            var TipoName = cmbTipoUser.Text;
            var Money = nudRemainingMoney.Value;
            var Query = new PlQuery("puedo_viajar_a('" + SourceName + "'," + TipoName + "," + Money + ",AV)");
            try
            {
                foreach(var q in Query.SolutionVariables)
                {
                    lstWhere.Items.Add(q["AV"].ToString());
                }
            }
            catch (PlException) { }
            if (lstWhere.Items.Count == 0) MessageBox.Show("No hay suficiente dinero para algun destino");
        }
    }
}
