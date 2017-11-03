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

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dictionary = new Dictionary<String, Int32>();
            cmbAvenidas.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDistritos.DropDownStyle = ComboBoxStyle.DropDownList;
            Environment.SetEnvironmentVariable("Path", @"C:\\Program Files\\swipl\\bin");
            String[] param = { "-q", "-f", @"Trabajo2.pl" };
            PlEngine.Initialize(param);
            var Qload = new PlQuery("load('Trabajo2.bd')");
            try
            {
                Qload.NextSolution();
            }
            catch (PlException){}
            InitializeDict();
            Query(cmbAvenidas, "siguiente_avenida(AV,_)", "AV");
            Query(cmbDistritos, "pertenece_distrito(_,Distrito)", "Distrito");
            Query(cmbTipoPasaje, "tipo_De_pasaje(Tipo,_,_)", "Tipo");
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
                    }
                }
            }
            catch (PlException) { }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            PlEngine.PlCleanup();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnVerParaderos_Click(object sender, EventArgs e)
        {
            var param = cmbDistritos.SelectedText.ToString();
            var Query = new PlQuery("pertenece_distrito(Paraderos,"+param+")");
        }
    }
}
