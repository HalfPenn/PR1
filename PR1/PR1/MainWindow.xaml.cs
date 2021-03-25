using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MessageBox = System.Windows.Forms.MessageBox;

namespace PR1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btPass_Click(object sender, RoutedEventArgs e)
        {
            string pass = "2580g";
            if (Tbpass.Text == pass)
            {
                lbMain.Visibility = Visibility.Visible;

                ListB1.Visibility = Visibility.Visible;
                BtReda.Visibility = Visibility.Visible;
                LbDni.Visibility = Visibility.Visible;

                lbStrok.Visibility = Visibility.Visible;
                tbStrok.Visibility = Visibility.Visible;
                BtStrok.Visibility = Visibility.Visible;

                tbPere.Visibility = Visibility.Visible;
                btPere.Visibility = Visibility.Visible;

                btDate.Visibility = Visibility.Visible;

                btPass.Visibility = Visibility.Hidden;
                lbPs.Visibility = Visibility.Hidden;
                Tbpass.Visibility = Visibility.Hidden;
            }
            else
            {
                MessageBox.Show("Неверный пароль!");
            }
        }

        private void BtReda_Click(object sender, RoutedEventArgs e)
        {
            ListB1.IsEnabled = true;
        }

        private void BtStrok_Click(object sender, RoutedEventArgs e)
        {
            tbPere.AppendText(tbStrok.Text + Environment.NewLine);
        }

        private void btPere_Click(object sender, RoutedEventArgs e)
        {
            string text = ((ListBoxItem)ListB1.SelectedItem).Content.ToString();
            tbPere.AppendText(text + Environment.NewLine);
        }

        private void btDate_Click(object sender, RoutedEventArgs e)
        {
            dpDate.Visibility = Visibility.Visible;
        }

        void dbDate_DateChanged(object sender, DateRangeEventArgs e)
        {
            lbMain.Content = String.Format("Вы выбрали + {0}", e.Start.ToLongDateString());
            
        }
    }
}
