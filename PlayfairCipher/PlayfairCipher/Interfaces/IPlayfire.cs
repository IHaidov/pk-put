using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayfairCipher.Interfaces
{
    internal interface IPlayfire
    {
        public string Encrypt(string text, string key);
        public string Decrypt(string text, string key);
        public void GenerateTable(string text, string key);

    }
}
