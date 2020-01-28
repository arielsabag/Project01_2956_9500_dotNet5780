using MahApps.Metro.Controls;
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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace PL
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : MetroWindow
    {
        public Window1()
        {
            InitializeComponent();
        }
        private void ToggleMainFlyout(object sender, RoutedEventArgs e)
        {
            if (MainFlyout.IsOpen)
            {
                CloseOpenFlyouts(sender as Button);
            }
            else
            {
                ShowFlyout(0);
                //MenuIcon.Kind = PackIconMaterialKind.Backburger;
            }
        }
        private void CloseOpenFlyouts(Button btn)
        {
            var closeMain = true;

            for (int i = 1; i < 6; i++)
            {
                if ((Flyouts.Items[i] as Flyout).IsOpen)
                {
                    HideFlyout(i);
                    closeMain = btn.Name == "" ? false : true;
                    break;
                }
            }

            if (closeMain)
            {
                //MenuIcon.Kind = PackIconMaterialKind.Menu;
                HideFlyout(0);
            }
        }
        private void ShowFlyout(int index)
            {
            var flyout = Flyouts.Items.GetItemAt(index) as Flyout;
            flyout.Theme = FlyoutTheme.Accent;
            flyout.IsOpen = true;
        }

        private void HideFlyout(int index)
        {
            var flyout = Flyouts.Items.GetItemAt(index) as Flyout;
            flyout.IsOpen = false;
        }
        private void ToggleTools(object sender, RoutedEventArgs e)
        {
            if (ToolsFlyout.IsOpen == true)
            {
                ToolsFlyout.IsOpen = false;
            }
            else
            {
                ToolsFlyout.IsOpen = true;
            }
        }
        private async void ShowAbout(object sender, RoutedEventArgs e)
        {
            //await this.ShowMetroDialogAsync(Resources["AboutUsDialog"] as BaseMetroDialog);
        }

        private void ToggleSubFlyouts(object sender, RoutedEventArgs e)
        {
            var btn = sender as Button;
            if (MainWindow.i==1)
            {
                ShowFlyout(1 + 1);
                int tmp = MainFlyoutPanell.Children.IndexOf(btn);

            }
            else
            {

                ShowFlyout(MainFlyoutPanel.Children.IndexOf(btn) + 1);
                int tmp1 = MainFlyoutPanel.Children.IndexOf(btn);
            }

            MainWindow.i++;
           

        }
        private UserControl MagicallyCreateInstance(string className)
        {
            var assembly = System.Reflection.Assembly.GetExecutingAssembly();
            Console.WriteLine(className);
            var type = assembly.GetTypes().First(t => t.Name == className);
            return (UserControl)Activator.CreateInstance(type, new object[] { this });
        }
        private void HandleSubFlyouts(object sender, RoutedEventArgs e)
        {
            var btn = sender as Button;
            CloseOpenFlyouts(btn);
            var res = MagicallyCreateInstance(btn.Name);
            mainContent.Children.Clear();
            mainContent.Children.Add(res);
            res.Loaded += (sdr, evt) => res.BeginStoryboard(Application.Current.Resources["sb"] as Storyboard);
        }
    }
}
