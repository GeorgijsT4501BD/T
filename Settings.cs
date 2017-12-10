using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Ecrypt_Serialize_BD
{
    public class Settings
    {
        public List<User> Users = new List<User>();

        internal void Save()
        {
           
            string filename = Path.pathList;
            if (File.Exists(filename))
                File.Delete(filename);

            using (FileStream fs = new FileStream(filename, FileMode.Create))
            {
                XmlSerializer xs = new XmlSerializer(typeof(Settings));
                xs.Serialize(fs, this);
                fs.Close();
            }

        }

        internal static Settings Load()
        {
            string filename = Path.pathList;
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

        internal void AddUser(User user)
        {
            Users.Add(user);
        }

    }
}
