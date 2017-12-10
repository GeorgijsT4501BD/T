using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Ecrypt_Serialize_BD
{
    public class User
    {


        public string Username { get; set; }
        public string Password { get; set; }

        internal void Save()
        {
            string filename = Path.path;
            string list = Path.pathList;
            if (File.Exists(filename))
                File.Delete(filename);

            FileStream fs1 = new FileStream(list, FileMode.Append);
            using (FileStream fs = new FileStream(filename, FileMode.Create))
            {
                XmlSerializer xs = new XmlSerializer(typeof(Settings));
                xs.Serialize(fs, this);
                xs.Serialize(fs1, this);
                fs.Close();
            }

        }

        internal static Settings Load()
        {
            string filename = Path.path;
            Settings sett = null;
            if (File.Exists(filename))
            {
                using (FileStream fs = new FileStream(filename, FileMode.Open))
                {
                    XmlSerializer xs = new XmlSerializer(typeof(Settings));
                    sett = (Settings)xs.Deserialize(fs);
                    fs.Close();
                }
            }
            else
                sett = new Settings();
            return sett;
        }

        internal string Decrypt()
        {
            string dec;
            try
            {
                dec = Cryptor.Decr(Password);
            }
            catch
            {
                dec = Password;
            }
            return dec;
        }


    }
}
