using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winformsapp_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            var name = tbName.Text;
            //MessageBox.Show("Hello "+name+" Welcome to Jamaica.");
            lblName.Text = $"Hello {name}. You are welcom here!";
        }

        private void label1_Enter(object sender, EventArgs e)
        {

        }
    }
}
