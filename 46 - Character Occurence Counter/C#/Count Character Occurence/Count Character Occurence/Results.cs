using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_Character_Occurence
{
    class Results
    {
        public void generateResults(Dictionary<char, int> characterCount, int totalCharacterCount, bool omitWhiteSpace, bool omitPunctuation)
        {
            // Order results, descending, by occurence
            var orderedCharCount = from pair in characterCount orderby pair.Value descending select pair;
            
            frmTextResults results = new frmTextResults();
            frmChartResults chart = new frmChartResults();

            foreach (KeyValuePair<char, int> entry in orderedCharCount)
            {
                if (!(omitWhiteSpace && Char.IsWhiteSpace(entry.Key))) // Filter white space when omit whitespace is checked.
                {
                    if (!(omitPunctuation && Char.IsPunctuation(entry.Key))) // Filter puntuation when omit punctuation is checked.
                    {
                        // Calculate percentage of occurance
                        decimal percentage = Math.Round(((decimal)entry.Value / (decimal)totalCharacterCount) * 100, 2);

                        // Append data entry to list
                        results.txtResult.AppendText("'" + entry.Key + "': " + entry.Value + " (" + percentage.ToString() + "%)");
                        results.txtResult.AppendText(Environment.NewLine);

                        // Update chart with entry
                        chart.chartCharOccurence.Series[0].Points.AddXY("'" + entry.Key.ToString() + "'", entry.Value);
                    }
                }
            }

            // Display the results
            results.Show();
            chart.Show();
        }

    }
}
