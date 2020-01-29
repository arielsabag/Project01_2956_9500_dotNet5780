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
    /// Interaction logic for HostingUnitFirstWindow.xaml
    /// </summary>
    public partial class HostingUnitFirstWindow : Window
    {
        public static BL.Bl_imp bbb = new BL.Bl_imp();
        public List<BE.GuestRequest> guestRequestList;
        public List<BE.BankBranch> BankBranchList;
        public List<BE.HostingUnit> HostingUnitList;
        public static List<BE.Order> OrderList;
        public HostingUnitFirstWindow()
        {
            InitializeComponent();
            guestRequestList = bbb.getAllGuestsRequestsList();
            BankBranchList = bbb.getAllBankBranchesInIsraelList();
            HostingUnitList = bbb.getAllHostingUnitsList();
            OrderList = bbb.getAllOrdersList();


            lvgetAllGuestsRequestsList.ItemsSource = guestRequestList;
            lvgetAllBankBranchesInIsraelList.ItemsSource = BankBranchList;
            lvgetAllOrdersList.ItemsSource = OrderList;
            lvgetAllHostingUnitsList.ItemsSource = HostingUnitList;
            lvgetAllHostingUnitsList2.ItemsSource = HostingUnitList;
            listorders.ItemsSource = OrderList;
            StatusComboBox.ItemsSource = BE.enum_s.orderStatus.GetValues(typeof(BE.enum_s.orderStatus));

        }

        private void UpdateOrder_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                BE.Order AB = (BE.Order)(listorders.SelectedItem);

                MainWindow.bl.updateOrder(AB);
                MessageBox.Show("Successfully updated");

            }
            catch (Exception)
            {

                MessageBox.Show("After the order status has changed to 'closing a deal' it is forbidden to change the order status anymore.");
            }

        }

        private void listorders_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            BE.Order a = (BE.Order)(listorders.SelectedItem);
            GuestRequestKeyTextBox.Text = a.GuestRequestKey;
            HostingUnitKeyTextBox.Text = a.HostingUnitKey;
            OrderDateTextBox.Text = a.OrderDate.ToString();
            OrderKeyTextBox.Text = a.OrderKey;
            CreateDateTextBox.Text = a.CreateDate.ToString();
            StatusComboBox.Text = a.Status.ToString();
        }
    }
}
