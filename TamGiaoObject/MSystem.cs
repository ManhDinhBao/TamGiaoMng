using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace TamGiaoObject
{
    public class MSystem
    {
        public static MDataBase LoadDBConfig()
        {
            try
            {
                XmlDocument xml = new XmlDocument();
                xml.Load(@"XMLFile\DBConfig.xml");
                string ip       = xml.DocumentElement.SelectSingleNode("/DBConfiguration/IP").InnerText;
                string port     = xml.DocumentElement.SelectSingleNode("/DBConfiguration/Port").InnerText;
                string name     = xml.DocumentElement.SelectSingleNode("/DBConfiguration/Name").InnerText;
                string account  = xml.DocumentElement.SelectSingleNode("/DBConfiguration/Account").InnerText;
                string password = xml.DocumentElement.SelectSingleNode("/DBConfiguration/Password").InnerText;

                MDataBase dataBase = new MDataBase(ip, name, port, account, password);

                return dataBase;
            }
            catch
            {
                return null;
            }
            
        }

        public static bool SaveDBConfig(MDataBase dataBase)
        {
            try
            {
                XmlDocument xml = new XmlDocument();
                xml.Load(@"XMLFile\DBConfig.xml");
                xml.DocumentElement.SelectSingleNode("/DBConfiguration/IP").InnerText = dataBase.IP;
                xml.DocumentElement.SelectSingleNode("/DBConfiguration/Port").InnerText = dataBase.Port;
                xml.DocumentElement.SelectSingleNode("/DBConfiguration/Name").InnerText = dataBase.Name;
                xml.DocumentElement.SelectSingleNode("/DBConfiguration/Account").InnerText = dataBase.Account;
                xml.DocumentElement.SelectSingleNode("/DBConfiguration/Password").InnerText = dataBase.Password;

                xml.Save(@"XMLFile\DBConfig.xml");
                return true;
            }
            catch
            {
                return false;
            }
            
        }
    }
}
