using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Password_Generator
{
    class Password
    {
        public string Generate(int length)
        {
            string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^*().?/~";
            string password = "";

            Random rand = new Random();
            for (int i = 0; i < length; i++)
                password += chars[rand.Next(0, chars.Length - 1)];

            return password;
        }
    }
}
