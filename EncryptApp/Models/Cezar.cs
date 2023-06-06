using EncryptApp.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncryptApp.Models
{
    public class Cezar : BaseEncryptionAlgorithm
    {
        public int Key { get; set; }
        public override string Decrypt(string text)
        {
            throw new NotImplementedException();
        }

        public override string Encrypt(string text)
        {
            throw new NotImplementedException();
        }
    }
}
