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

namespace LogForm
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            lb_hello.Visibility = Visibility.Visible;
            lb_par.Visibility = Visibility.Visible;
            tb_par.Visibility = Visibility.Visible;
            bt_enter.Visibility = Visibility.Visible;
            lb_days.Visibility = Visibility.Hidden;
            ls_days.Visibility = Visibility.Hidden;
            bt_days.Visibility = Visibility.Hidden;
            lb_new.Visibility = Visibility.Hidden;
            tb_new.Visibility = Visibility.Hidden;
            bt_new.Visibility = Visibility.Hidden;
            lb_data.Visibility = Visibility.Hidden;
            tb_data.Visibility = Visibility.Hidden;
            bt_data.Visibility = Visibility.Hidden;
            bt_date.Visibility = Visibility.Hidden;
            datepicker.Visibility = Visibility.Hidden;
            ls_days.IsEnabled = false;

            datepicker.SelectedDate = DateTime.Today;
        }
        private void Bt_enter_Click(object sender, RoutedEventArgs e)
        {
            string pass = "xyz";
            if (tb_par.Text == pass)
            {
                tb_par.Background = Brushes.Green;
                lb_hello.Visibility = Visibility.Hidden;
                lb_par.Visibility = Visibility.Hidden;
                tb_par.Visibility = Visibility.Hidden;
                bt_enter.Visibility = Visibility.Hidden;
                lb_days.Visibility = Visibility.Visible;
                ls_days.Visibility = Visibility.Visible;
                bt_days.Visibility = Visibility.Visible;
                lb_new.Visibility = Visibility.Visible;
                tb_new.Visibility = Visibility.Visible;
                bt_new.Visibility = Visibility.Visible;
                lb_data.Visibility = Visibility.Visible;
                tb_data.Visibility = Visibility.Visible;
                bt_data.Visibility = Visibility.Visible;
                bt_date.Visibility = Visibility.Visible;
            }
            else
            {
                tb_par.Background = Brushes.Red;
                MessageBox.Show("Ошибка пароля!!!");
            }
        }

        private void Bt_new_Click(object sender, RoutedEventArgs e)
        {
            ls_days.Items.Add("");
            ls_days.Items[ls_days.Items.Count - 1] = tb_new.Text;

        }

        private void Bt_days_Click(object sender, RoutedEventArgs e)
        {
            if (ls_days.IsEnabled == true)
                ls_days.IsEnabled = false;
            else if (ls_days.IsEnabled == false)
                ls_days.IsEnabled = true;
        }

        private void Bt_date_Click(object sender, RoutedEventArgs e)
        {
            datepicker.Visibility = Visibility.Visible;
        }

        private void Datepicker_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            Title = "{Binding WindowTitle}";
            var date = datepicker.SelectedDate.Value.Date.ToShortDateString();
            string dateString = date.ToString();
            Title = dateString;
        }

        private void Bt_data_Click(object sender, RoutedEventArgs e)
        {
            string text = ((ListBoxItem)ls_days.SelectedItem).Content.ToString();
            tb_data.AppendText(text + Environment.NewLine);
        }
    }
}
