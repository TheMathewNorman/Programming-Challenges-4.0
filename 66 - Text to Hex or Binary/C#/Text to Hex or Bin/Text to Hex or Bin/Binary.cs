using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_to_Hex_or_Bin
{
    class Binary
    {
        public string ToBinary(string input)
        {
            string binaryResult = string.Empty;

            foreach (char c in input)
                binaryResult += Convert.ToString((int)c, 2).PadLeft(8, '0');

            return binaryResult;
        }
        public string FromBinary(string input)
        {
            string stringResult = string.Empty;



            return stringResult;
        }
    }
}
