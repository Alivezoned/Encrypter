using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text;
using System.Collections;
using System.IO;

namespace EncryptDecrypter
{
    class Cryptography
    {
        public String encrypt(String text)
        {
            StringBuilder build = new StringBuilder();
            char[] character = text.ToCharArray();
            foreach (char c in character)
            {
                char outx = (char)(c + 2);
                build.Append(outx);
            }
            return build.ToString();
        }

        public String decrypt(String text)
        {
            StringBuilder build = new StringBuilder();
            char[] character = text.ToCharArray();
            foreach (char c in character)
            {
                char outx = (char)(c - 2);
                build.Append(outx);
            }
            return build.ToString();
        }
    }
}
