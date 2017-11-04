namespace T2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.cmbDistritos = new System.Windows.Forms.ComboBox();
            this.cmbAvenidasIni = new System.Windows.Forms.ComboBox();
            this.lstbResult1 = new System.Windows.Forms.ListBox();
            this.cmbTipoPasaje = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnVerParaderos = new System.Windows.Forms.Button();
            this.cmbAvenidasFin = new System.Windows.Forms.ComboBox();
            this.lblPago = new System.Windows.Forms.Label();
            this.btnCalcularPago = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbTipoUser = new System.Windows.Forms.ComboBox();
            this.cmbSource = new System.Windows.Forms.ComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.nudRemainingMoney = new System.Windows.Forms.NumericUpDown();
            this.lstWhere = new System.Windows.Forms.ListBox();
            this.btnSee = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRemainingMoney)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(103, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sistema Experto: Cobro de rutas";
            // 
            // cmbDistritos
            // 
            this.cmbDistritos.FormattingEnabled = true;
            this.cmbDistritos.Location = new System.Drawing.Point(9, 36);
            this.cmbDistritos.Name = "cmbDistritos";
            this.cmbDistritos.Size = new System.Drawing.Size(174, 21);
            this.cmbDistritos.TabIndex = 1;
            // 
            // cmbAvenidasIni
            // 
            this.cmbAvenidasIni.FormattingEnabled = true;
            this.cmbAvenidasIni.Location = new System.Drawing.Point(169, 42);
            this.cmbAvenidasIni.Name = "cmbAvenidasIni";
            this.cmbAvenidasIni.Size = new System.Drawing.Size(121, 21);
            this.cmbAvenidasIni.TabIndex = 2;
            // 
            // lstbResult1
            // 
            this.lstbResult1.FormattingEnabled = true;
            this.lstbResult1.Location = new System.Drawing.Point(9, 92);
            this.lstbResult1.Name = "lstbResult1";
            this.lstbResult1.Size = new System.Drawing.Size(192, 147);
            this.lstbResult1.TabIndex = 3;
            // 
            // cmbTipoPasaje
            // 
            this.cmbTipoPasaje.FormattingEnabled = true;
            this.cmbTipoPasaje.Location = new System.Drawing.Point(8, 42);
            this.cmbTipoPasaje.Name = "cmbTipoPasaje";
            this.cmbTipoPasaje.Size = new System.Drawing.Size(121, 21);
            this.cmbTipoPasaje.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Paraderos en el distrito";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Selecciona un distrito";
            // 
            // btnVerParaderos
            // 
            this.btnVerParaderos.Location = new System.Drawing.Point(12, 254);
            this.btnVerParaderos.Name = "btnVerParaderos";
            this.btnVerParaderos.Size = new System.Drawing.Size(75, 23);
            this.btnVerParaderos.TabIndex = 7;
            this.btnVerParaderos.Text = "Ver";
            this.btnVerParaderos.UseVisualStyleBackColor = true;
            this.btnVerParaderos.Click += new System.EventHandler(this.btnVerParaderos_Click);
            // 
            // cmbAvenidasFin
            // 
            this.cmbAvenidasFin.FormattingEnabled = true;
            this.cmbAvenidasFin.Location = new System.Drawing.Point(322, 42);
            this.cmbAvenidasFin.Name = "cmbAvenidasFin";
            this.cmbAvenidasFin.Size = new System.Drawing.Size(121, 21);
            this.cmbAvenidasFin.TabIndex = 8;
            // 
            // lblPago
            // 
            this.lblPago.AutoSize = true;
            this.lblPago.Location = new System.Drawing.Point(5, 79);
            this.lblPago.Name = "lblPago";
            this.lblPago.Size = new System.Drawing.Size(0, 13);
            this.lblPago.TabIndex = 9;
            // 
            // btnCalcularPago
            // 
            this.btnCalcularPago.Location = new System.Drawing.Point(368, 79);
            this.btnCalcularPago.Name = "btnCalcularPago";
            this.btnCalcularPago.Size = new System.Drawing.Size(75, 23);
            this.btnCalcularPago.TabIndex = 10;
            this.btnCalcularPago.Text = "Calcular Pago";
            this.btnCalcularPago.UseVisualStyleBackColor = true;
            this.btnCalcularPago.Click += new System.EventHandler(this.btnCalcularPago_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Tipo de usuario";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(166, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Inicio";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(319, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Fin";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Inicio";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 45);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Tipo de usuario";
            // 
            // cmbTipoUser
            // 
            this.cmbTipoUser.FormattingEnabled = true;
            this.cmbTipoUser.Location = new System.Drawing.Point(17, 61);
            this.cmbTipoUser.Name = "cmbTipoUser";
            this.cmbTipoUser.Size = new System.Drawing.Size(121, 21);
            this.cmbTipoUser.TabIndex = 15;
            // 
            // cmbSource
            // 
            this.cmbSource.FormattingEnabled = true;
            this.cmbSource.Location = new System.Drawing.Point(17, 126);
            this.cmbSource.Name = "cmbSource";
            this.cmbSource.Size = new System.Drawing.Size(121, 21);
            this.cmbSource.TabIndex = 14;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(22, 92);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(481, 314);
            this.tabControl1.TabIndex = 18;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.LightSalmon;
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.cmbDistritos);
            this.tabPage1.Controls.Add(this.lstbResult1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.btnVerParaderos);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(473, 288);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Conocer Paraderos";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.LightSalmon;
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.cmbAvenidasIni);
            this.tabPage2.Controls.Add(this.cmbTipoPasaje);
            this.tabPage2.Controls.Add(this.cmbAvenidasFin);
            this.tabPage2.Controls.Add(this.lblPago);
            this.tabPage2.Controls.Add(this.btnCalcularPago);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(473, 288);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Calcular Pago";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.LightSalmon;
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.btnSee);
            this.tabPage3.Controls.Add(this.lstWhere);
            this.tabPage3.Controls.Add(this.nudRemainingMoney);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.cmbTipoUser);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.cmbSource);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(473, 288);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Que me alcanza";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 188);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Dinero Disponible";
            // 
            // nudRemainingMoney
            // 
            this.nudRemainingMoney.DecimalPlaces = 1;
            this.nudRemainingMoney.Location = new System.Drawing.Point(17, 204);
            this.nudRemainingMoney.Name = "nudRemainingMoney";
            this.nudRemainingMoney.Size = new System.Drawing.Size(120, 20);
            this.nudRemainingMoney.TabIndex = 20;
            // 
            // lstWhere
            // 
            this.lstWhere.FormattingEnabled = true;
            this.lstWhere.Location = new System.Drawing.Point(246, 61);
            this.lstWhere.Name = "lstWhere";
            this.lstWhere.Size = new System.Drawing.Size(183, 173);
            this.lstWhere.TabIndex = 21;
            // 
            // btnSee
            // 
            this.btnSee.Location = new System.Drawing.Point(17, 244);
            this.btnSee.Name = "btnSee";
            this.btnSee.Size = new System.Drawing.Size(75, 23);
            this.btnSee.TabIndex = 22;
            this.btnSee.Text = "Ver";
            this.btnSee.UseVisualStyleBackColor = true;
            this.btnSee.Click += new System.EventHandler(this.btnSee_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(243, 45);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(122, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "Lugares donde puedo ir:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(560, 432);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Sistema Experto";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRemainingMoney)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbDistritos;
        private System.Windows.Forms.ComboBox cmbAvenidasIni;
        private System.Windows.Forms.ListBox lstbResult1;
        private System.Windows.Forms.ComboBox cmbTipoPasaje;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnVerParaderos;
        private System.Windows.Forms.ComboBox cmbAvenidasFin;
        private System.Windows.Forms.Label lblPago;
        private System.Windows.Forms.Button btnCalcularPago;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbTipoUser;
        private System.Windows.Forms.ComboBox cmbSource;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown nudRemainingMoney;
        private System.Windows.Forms.ListBox lstWhere;
        private System.Windows.Forms.Button btnSee;
        private System.Windows.Forms.Label label10;
    }
}

