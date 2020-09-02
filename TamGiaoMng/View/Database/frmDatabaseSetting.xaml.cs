using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using TamGiaoObject;

namespace TamGiaoMng.View.Database
{
    /// <summary>
    /// Interaction logic for DatabaseSetting.xaml
    /// </summary>
    public partial class frmDatabaseSetting : Window
    {
        MDataBase dataBase;
        public frmDatabaseSetting()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            dataBase = MSystem.LoadDBConfig();
            if (dataBase != null)
            {
                tbIpAddress.Text = dataBase.IP == null ? "127.0.0.1" : dataBase.IP;
                tbPort.Text = dataBase.Port == null ? "1433" : dataBase.Port;
                tbDBName.Text = dataBase.Name == null ? "TGMng" : dataBase.Name;
                tbAccount.Text = dataBase.Account == null ? "admin" : dataBase.Account;
                tbPassword.Text = dataBase.Password == null ? "admin" : dataBase.Password;
            }
            else
            {
                tbIpAddress.Text = "";
                tbPort.Text = "";
                tbDBName.Text = "";
                tbAccount.Text = "";
                tbPassword.Text = "";
            }
        }

        private void btTest_Click(object sender, RoutedEventArgs e)
        {
            string conStr = dataBase.GenerateConnectString();
            try
            {
                SqlConnection conn = new SqlConnection(conStr);
                conn.Open();
                MessageBoxResult mbr = MessageBox.Show("Có thể kết nối tới máy chủ: "+dataBase.IP, "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
                conn.Close();
                conn.Dispose();
            }
            catch
            {
                MessageBox.Show("Kết nối thất bại!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btSave_Click(object sender, RoutedEventArgs e)
        {
            MDataBase dataBase = new MDataBase();
            dataBase.IP = tbIpAddress.Text;
            dataBase.Port = tbPort.Text;
            dataBase.Name = tbDBName.Text;
            dataBase.Account = tbAccount.Text;
            dataBase.Password = tbPassword.Text;

            if(MSystem.SaveDBConfig(dataBase))
            {
                MessageBoxResult mbr = MessageBox.Show("Lưu cấu hình thành công!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
                if(mbr == MessageBoxResult.OK)
                {
                    this.Hide();
                }               
            }
            else
            {
                MessageBox.Show("Không lưu được cấu hình!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}