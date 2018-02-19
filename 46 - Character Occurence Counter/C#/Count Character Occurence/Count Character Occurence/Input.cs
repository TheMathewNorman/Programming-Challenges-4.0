using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Count_Character_Occurence
{
    public partial class Input : Form
    {
        public Input()
        {
            InitializeComponent();
        }

        private Dictionary<char, int> charCount = new Dictionary<char, int>();
        private int total = 0;

        private void countCharacters(string input, bool caseInsensitive)
        {
            // Iterate through characters and count occurences and track total.
            char[] inputChars;

            // Adjust input to allow for case insensitivity in results
            if (caseInsensitive)
                inputChars = input.ToCharArray();
            else
                inputChars = input.ToUpper().ToCharArray();

            // Interate through the input characters and count the occurences of each.
            foreach (char c in inputChars)
            {
                if (!charCount.ContainsKey(c))
                    charCount.Add(c, 1);
                else
                    charCount[c]++;

                // Count the total number of occurences.
                total++;
            }
        }


        private void btnCount_Click(object sender, EventArgs e)
        {
            // If input is not empty, count the characters.
            if (txtInput.Text.Length == 0)
                MessageBox.Show("Please enter one or more characters into the box.", "Error");
            else
                countCharacters(txtInput.Text, !chkCaseInsensitive.Checked);

            // Display results
            Results results = new Results();
            results.generateResults(charCount, total, chkWhiteSpace.Checked, chkPunctuation.Checked);
        }
    }
}
