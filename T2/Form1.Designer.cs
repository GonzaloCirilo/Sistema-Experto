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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbDistritos = new System.Windows.Forms.ComboBox();
            this.cmbAvenidas = new System.Windows.Forms.ComboBox();
            this.lstbResult1 = new System.Windows.Forms.ListBox();
            this.cmbTipoPasaje = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnVerParaderos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(329, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sistema Experto";
            // 
            // cmbDistritos
            // 
            this.cmbDistritos.FormattingEnabled = true;
            this.cmbDistritos.Location = new System.Drawing.Point(40, 80);
            this.cmbDistritos.Name = "cmbDistritos";
            this.cmbDistritos.Size = new System.Drawing.Size(174, 21);
            this.cmbDistritos.TabIndex = 1;
            // 
            // cmbAvenidas
            // 
            this.cmbAvenidas.FormattingEnabled = true;
            this.cmbAvenidas.Location = new System.Drawing.Point(575, 80);
            this.cmbAvenidas.Name = "cmbAvenidas";
            this.cmbAvenidas.Size = new System.Drawing.Size(121, 21);
            this.cmbAvenidas.TabIndex = 2;
            // 
            // lstbResult1
            // 
            this.lstbResult1.FormattingEnabled = true;
            this.lstbResult1.Location = new System.Drawing.Point(40, 136);
            this.lstbResult1.Name = "lstbResult1";
            this.lstbResult1.Size = new System.Drawing.Size(192, 95);
            this.lstbResult1.TabIndex = 3;
            this.lstbResult1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // cmbTipoPasaje
            // 
            this.cmbTipoPasaje.FormattingEnabled = true;
            this.cmbTipoPasaje.Location = new System.Drawing.Point(392, 80);
            this.cmbTipoPasaje.Name = "cmbTipoPasaje";
            this.cmbTipoPasaje.Size = new System.Drawing.Size(121, 21);
            this.cmbTipoPasaje.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Paraderos en el distrito";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Selecciona un distrito";
            // 
            // btnVerParaderos
            // 
            this.btnVerParaderos.Location = new System.Drawing.Point(40, 237);
            this.btnVerParaderos.Name = "btnVerParaderos";
            this.btnVerParaderos.Size = new System.Drawing.Size(75, 23);
            this.btnVerParaderos.TabIndex = 7;
            this.btnVerParaderos.Text = "Ver";
            this.btnVerParaderos.UseVisualStyleBackColor = true;
            this.btnVerParaderos.Click += new System.EventHandler(this.btnVerParaderos_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 309);
            this.Controls.Add(this.btnVerParaderos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbTipoPasaje);
            this.Controls.Add(this.lstbResult1);
            this.Controls.Add(this.cmbAvenidas);
            this.Controls.Add(this.cmbDistritos);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbDistritos;
        private System.Windows.Forms.ComboBox cmbAvenidas;
        private System.Windows.Forms.ListBox lstbResult1;
        private System.Windows.Forms.ComboBox cmbTipoPasaje;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnVerParaderos;
    }
}

