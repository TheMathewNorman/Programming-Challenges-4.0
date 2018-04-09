using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Text_to_Hex_or_Bin
{
    public partial class formDisplay : Form
    {
        public formDisplay()
        {
            InitializeComponent();
        }

        private void btnToBinary_Click(object sender, EventArgs e)
        {
            Binary binary = new Binary();
            txtResult.Text = binary.ToBinary(txtInput.Text);
        }
    }
}
