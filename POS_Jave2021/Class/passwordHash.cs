using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_Jave2021.Class
{
    class passwordHash
    {
        /// <summary>
        /// password hash encryptor
        /// </summary>
        /// <param name="pass"></param>
        /// <returns></returns>
        public static string encryptor(string pass)
        {
            string[] stringarray = { "a", "e", "i", "o", "u" };
            string[] numberarray = { "1", "2", "3", "4", "5" };

            for (int i = 0; i < stringarray.Length; i++)
            {
                pass = pass.Replace(stringarray[i].ToString(), numberarray[i].ToString());
            }

            return pass;
        }

        /// <summary>
        /// password hash decryptor
        /// </summary>
        /// <param name="pass"></param>
        /// <returns></returns>
        public static string decryptor(string pass)
        {
            string[] stringarray = { "a", "e", "i", "o", "u" };
            string[] numberarray = { "1", "2", "3", "4", "5" };

            for (int i = 0; i < stringarray.Length; i++)
            {
                pass = pass.Replace(numberarray[i].ToString(), stringarray[i].ToString());
            }

            return pass;
        }
    }
}
