using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ROT_13
{
    public partial class ROT13 : Form
    {
        public ROT13()
        {
            InitializeComponent();
        }

        private string runCipher(string input)
        {  
            string cipherOutput = "";
            
            // Iterate through the characters of the input
            foreach (char c in input.ToCharArray())
            {
                if (char.IsUpper(c))
                {
                    // If the current character is an uppercase letter, apply the rotation to uppercase letters.
                    int value = (int)c - 65;
                    value = ((value + 13) % 26) + 65;

                    // Append the resulting character to the output string.
                    cipherOutput += Convert.ToChar(value).ToString();
                }
                else if (char.IsLower(c))
                {
                    // If the current character is an lowercase letter, apply the rotation to lowercase letters.
                    int value = (int)c - 97;
                    value = ((value + 13) % 26) + 97;

                    // Append the resulting character to the output string.
                    cipherOutput += Convert.ToChar(value).ToString();
                }
                else
                {
                    // No changes for non-alphabetic characters.
                    cipherOutput += c.ToString();
                }
            }

            // Returned the formed string.
            return cipherOutput;
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            // Display the output.
            txtResult.Text = runCipher(txtInput.Text);
        }

        private void btnDecode_Click(object sender, EventArgs e)
        {
            // Reverse the cipher
            txtInput.Text = txtResult.Text;
            txtResult.Text = runCipher(txtInput.Text);
        }
    }
}
