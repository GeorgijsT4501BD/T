using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Ecrypt_Serialize_BD
{
    public class Cryptor
    {
        private static string key = "<RSAKeyValue><Modulus>3HEedqHRSXmfViFq1RBQC8t4PFz1dCjDVTUKgxJyWnD+Jm1ycXDfWZWkdtTTg1MKYpg07kyw1m4UVxEjXmIxQDTDB/9urX6a+IHuBvY8av0BrWMHJ5XTSJYNYdmDUugTNgyh2oFzt32N95hAYr/NPoQy2G2Hx/J9M20F0VFpYk0=</Modulus><Exponent>AQAB</Exponent><P>+h6FimyyLbM+SIg8hOyoIs4SuKQx+JkFM9zzrBQjsMP9fm8clOE39UkX/VtDRznxi/wI6fSlF2o1sZ5A5Z/Qyw==</P><Q>4Z/31HXlWNeClGs2HjHnzy+i2oCgigM2cGykQRlqetcoqhBP8FDNnnnAGlaXY+dHBVPzOCQdAapWyR5JZ3YuRw==</Q><DP>gb6Lbz7rPqGYUW+6VQmePk+/jmA+O8LE3B5lmIHp8av5NzjUDra1nFuKQjaxM6VvEzpuNU5exUKnD7gT2gmI+Q==</DP><DQ>jgdsM/NPP4DSc2mV9KYHvZXIF3IXHSnukBDjyRMdw1xD/eIs4CONfHA57JqLzFjfjUwOdE3PcKfw38PQA3ASqw==</DQ><InverseQ>TXghgmYGkLRnuSgXQYdc2CiT9o7ZGR1/C7O+QGt/zbwKLmcNYyf9D27Ymyj+WWyYnie/ka7CT9smu+ddUmHwGQ==</InverseQ><D>sBv672GldqKghcnatG780/9whiDpwywRqU/fnwksrE5a7E5BwJkhBkvDgV/TvrWntU7N8pb4K8bznv9FF1Ew8BNjynAqmh58rkeyHK8uSeFKAT9mHPtl3oSDGx0hBDRhYqiqTN3bigwyR2+H7vU83N/HF6F4B99BeSZVHlQ5Xi0=</D></RSAKeyValue>";

        internal static string Decr(string password)
        {
            byte[] decr;
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
            rsa.FromXmlString(key);
            decr = rsa.Decrypt(Convert.FromBase64String(password), false);
            return toString(decr);
        }

        private static string toString(byte[] decr)
        {
            return Encoding.UTF8.GetString(decr);
        }

        internal static string Encr(string text)
        {
            byte[] enc;
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
            rsa.FromXmlString(key);
            enc = rsa.Encrypt(toByte(text),false);
            return Convert.ToBase64String(enc);
        }

        private static byte[] toByte(string text)
        {
            return Encoding.UTF8.GetBytes(text);
        }
    }
}
