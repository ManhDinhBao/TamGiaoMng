using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using TamGiaoMng.View.Employee;
using TamGiaoMng.View.Setting;

namespace TamGiaoMng
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void MenuEmployee_Click(object sender, RoutedEventArgs e)
        {
            foreach (TabItem tab in tabMain.Items)
            {
                if (tab.Name == "tabEmployee")
                {
                    tabMain.SelectedItem = tab;
                    return;
                }
            }

            ucEmployee uc = new ucEmployee();
            TabItem tabItem = new TabItem();
            tabItem.Name = "tabEmployee";
            tabItem.Header = "Nhân viên";
            tabItem.Content = uc;

            tabMain.Items.Add(tabItem);
            tabMain.SelectedItem = tabItem;
            
        }

        private void Button_Close_Tab_Click(object sender, RoutedEventArgs e)
        {
            Button b = sender as Button;
            tabMain.Items.RemoveAt(tabMain.SelectedIndex);
        }

        private void AddTab(UserControl uc, string tabName, string tabHeader)
        {

        }

    }
}
