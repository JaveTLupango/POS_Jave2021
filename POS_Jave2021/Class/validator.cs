using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_Jave2021.Class
{
    class validator
    {
        /// <summary>
        /// email validator
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public static bool email(string email)
        {
                try
                {
                    var addr = new System.Net.Mail.MailAddress(email);
                    return addr.Address == email;
                }
                catch
                {
                    return false;
                }            
        }
        /// <summary>
        /// Philippines phone number validator
        /// </summary>
        /// <param name="cpNum"></param>
        /// <returns></returns>
        public static string phonenumber(string cpNum)
        {
            if (cpNum.Length == 11)
            {                
                string vpho = cpNum.Substring(0,4);
                cpNum = "GOOD's - ";
                ///
                /// Smart or Talk N' Text
                ///
                if (vpho == "0813" || vpho == "0907" || vpho == "0908" || vpho == "0909" || vpho == "0910" ||
                    vpho == "0911" || vpho == "0912" || vpho == "0913" || vpho == "0914" || vpho == "0918" ||
                    vpho == "0919" || vpho == "0920" || vpho == "0921" || vpho == "0928" || vpho == "0929" ||
                    vpho == "0930" || vpho == "0938" || vpho == "0939" || vpho == "0940" || vpho == "0946" ||
                    vpho == "0947" || vpho == "0948" || vpho == "0949" || vpho == "0950" || vpho == "0951" ||
                    vpho == "0970" || vpho == "0981" || vpho == "0989" || vpho == "0992" || vpho == "0998" || vpho == "0999")
                {
                    cpNum += "Smart or Talk N' Text";
                }
                ///
                /// Globe or TM
                ///
                else if (vpho == "0817" || vpho == "0905" || vpho == "0906" || vpho == "0915" || vpho == "0916" ||
                        vpho == "0917" || vpho == "0926" || vpho == "0927" || vpho == "0935" || vpho == "0936" ||
                        vpho == "0937" || vpho == "0945" || vpho == "0955" || vpho == "0956" || vpho == "0965" ||
                        vpho == "0966" || vpho == "0975" || vpho == "0977" || vpho == "0994" || vpho == "0995" ||
                        vpho == "0996" || vpho == "0997")
                {
                    cpNum += "Globe or TM";
                }

                ///
                /// Sun Cellular
                ///
                else if (vpho == "0922" || vpho == "0923" || vpho == "0924" || vpho == "0925" || vpho == "0931" ||
                         vpho == "0932" || vpho == "0933" || vpho == "0934" || vpho == "0941" || vpho == "0942" ||
                         vpho == "0943" || vpho == "0944")
                {
                    cpNum += "Sun Cellular";
                }
            }
            else
            {
                cpNum = "Invalid Phone Number";
            }
            return cpNum;
        }
    }
}
