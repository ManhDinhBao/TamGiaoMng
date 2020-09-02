using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TamGiaoObject
{
    public class MDataBase
    {
        public string IP { get; set; }
        public string Name { get; set; }
        public string Port { get; set; }
        public string Account { get; set; }
        public string Password { get; set; }
        public bool IsConnect { get; set; }
        public string Status { get; set; }
        public string ImageSrc { get; set; }

        public MDataBase()
        {
            IsConnect = false;
            Status = "Chưa kết nối";
            ImageSrc = "/Icon/disconnect.png";
        }

        public MDataBase(string iP, string name, string port, string account, string password)
        {
            IP = iP;
            Name = name;
            Port = port;
            Account = account;
            Password = password;
            IsConnect = false;
            Status = "Chưa kết nối";
            ImageSrc = "/Icon/disconnect.png";
        }

        private void ChangeStatus()
        {
            if (IsConnect)
            {
                Status = "Đã kết nối";
                ImageSrc = "/Icon/connected.png";
            }
            else{
                Status = "Chưa kết nối";
                ImageSrc = "/Icon/disconnect.png";
            }
        }

        public string GenerateConnectString()
        {
            return "Data Source=" + IP + "," + Port + ";Initial Catalog = " + Name + ";User ID = " + Account + ";Password=" + Password + ";Integrated Security=SSPI;Connection Timeout=3";
        }
    }
}
