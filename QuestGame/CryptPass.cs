using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace QuestGame {
    internal class CryptPass {
        public static string cryptPassword(string password) {
            MD5 md5 = MD5.Create();
            byte[] sumbols = Encoding.ASCII.GetBytes(password);
            byte[] hash = md5.ComputeHash(sumbols);
            StringBuilder getCryptPassword = new StringBuilder();
            foreach (var b in hash) {
                getCryptPassword.Append(b.ToString());
            }
            return Convert.ToString(getCryptPassword);
        }
    }
}
