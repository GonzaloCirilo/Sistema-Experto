using SbsSW.SwiPlCs;
using SbsSW.SwiPlCs.Exceptions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Environment.SetEnvironmentVariable("Path", @"C:\\Program Files\\swipl\\bin");
            String[] param = { "-q" };
            PlEngine.Initialize(param);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            PlEngine.PlCleanup();
        }
    }
}
