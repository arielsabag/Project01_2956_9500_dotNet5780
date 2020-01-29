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
using System.Windows.Shapes;

namespace PL
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static BL.Bl_imp bl;

        public MainWindow()
        {
            InitializeComponent();
            bl = new BL.Bl_imp();
        }

        private void BtnLoginManager_Click(object sender, RoutedEventArgs e)
        {
            WebsiteManagerFirstWindow s = new WebsiteManagerFirstWindow();
            //s.Height = (System.Windows.SystemParameters.PrimaryScreenHeight * 0.89);
            //s.Width = (System.Windows.SystemParameters.PrimaryScreenWidth * 0.89);
            s.Show();
        }
        private void BtnLoginHost_Click(object sender, RoutedEventArgs e)
        {
            bool ok = false;
            foreach (BE.Host item in bl.getAllHostsList())
            {
                if ((hostUserNameTextBox.Text == item.UserName) && (hostPasswordTextBox.Text == item.Password))
                {

                    ok = true;
                    BE.Configuration.CurrentHost = item;
                }
            }
            if (ok)
            {
                HostingUnitFirstWindow s = new HostingUnitFirstWindow();

                //s.Height = (System.Windows.SystemParameters.PrimaryScreenHeight * 0.89);
                //s.Width = (System.Windows.SystemParameters.PrimaryScreenWidth * 0.89);
                s.Show();
            }
            else
            {
                MessageBox.Show("Wrong input");
            }



        }
        private void BtnLoginGuestRequest_Click(object sender, RoutedEventArgs e)
        {
            GuestRequestFirstWindow s = new GuestRequestFirstWindow();
            //s.Height = (System.Windows.SystemParameters.PrimaryScreenHeight * 0.89);
            //s.Width = (System.Windows.SystemParameters.PrimaryScreenWidth * 0.89);
            s.Show();
        }
    }
}
