using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Password_Generator
{
    public partial class frmPasswordGenerator : Form
    {
        public frmPasswordGenerator()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            Password password = new Password();
            string generatedPassword = password.Generate((int)numericUpDown1.Value);
            cmbPassword.Items.Add(generatedPassword);
            cmbPassword.Text = generatedPassword;
        }
    }
}
