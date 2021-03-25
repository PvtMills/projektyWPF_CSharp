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
using System.Windows.Threading;

namespace Clicker
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Img_tall_qiqi.Visibility = Visibility.Hidden;
            Img_M36.Visibility = Visibility.Hidden;
            Img_van228.Visibility = Visibility.Hidden;
        }
        int[] costs = new int[3] { 34000, 3250000, 456000 };
        int[] films = new int[3] { 200000, 210000, 225000 };
        long points = 1000000000;
        static int clickCount = 1;
        static int click = 1 * clickCount;
        long qiqis = 0;
        long tanks = 0;
        long dMasters = 0;
        double sol_b1 = 10 + 10 * (30 + click * 0.2);
        double sol_b2 = 80 + 80 * (320 + click * 3.2);
        double sol_b3 = 240 + 240 * (720 + click * 7.2);
        double sol_b4 = 720 + 720 * (2400 + click * 25.6);
        public void Update()
        {
            pts.Content = "Points: " + points;
            ppc.Content = "Points per click: " + click;
            curPts.Content = "Current points: " + points;
        }
        public void Update2()
        {
            clk.Content = "Click count: " + clickCount;
            click = click * clickCount;
        }
        public void Update3()
        {
            clk.Content = "Click count: " + clickCount;
            click = click / 2 * clickCount;
        }
        /*public void UpdateCSSim()
        {
            qAmounts.Content = "Qiqis: " + qiqis;
            spAmounts.Content = "Jacksons: " + tanks;
            vanAmounts.Content = "Drugs: " + dMasters;
        }*/

        private void Butt_lv1_Click(object sender, RoutedEventArgs e)
        {
            if (points >= (sol_b1))
            {
                points -= Convert.ToInt64(Math.Round(sol_b1));
                click += 3;
                Update();
            }
        }
        private void Butt_lv2_Click(object sender, RoutedEventArgs e)
        {
            if (points >= (sol_b2))
            {
                points -= Convert.ToInt64(Math.Round(sol_b2));
                click += 72;
                Update();
            }
        }

        private void Butt_lv3_Click(object sender, RoutedEventArgs e)
        {
            if (points >= (sol_b3))
            {
                points -= Convert.ToInt64(Math.Round(sol_b3));
                click += 812;
                Update();
            }
        }

        private void Butt_lv4_Click(object sender, RoutedEventArgs e)
        {
            if (points >= (sol_b4))
            {
                points -= Convert.ToInt64(Math.Round(sol_b4));
                click += 2124;
                Update();
            }
        }

        private void Butt_run_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Caco_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            points += click;
            Update();
        }

        private void Butt_RMK_Click(object sender, RoutedEventArgs e)
        {
            if (points >= 50000)
            {
                points -= 50000;
                DispatcherTimer timer = new DispatcherTimer();
                timer.Tick += new EventHandler(Timer_Tick);
                timer.Interval = TimeSpan.FromSeconds(1);
                timer.Start();
                Butt_RMK.Visibility = Visibility.Hidden;
            }

        }

        private void Butt_TpB_Click(object sender, RoutedEventArgs e)
        {
            if (points >= 5000000)
            {
                points -= 5000000;
                clickCount = 3;
                Update3();
                Butt_TpB.Visibility = Visibility.Hidden;
            }
        }

        private void Butt_DB_Click(object sender, RoutedEventArgs e)
        {
            if (points >= 100000)
            {
                points -= 100000;
                clickCount = 2;
                Update2();
                Butt_DB.Visibility = Visibility.Hidden;
            }
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            points += click;
            Update();
        }

        /*private void Car_bt_Click(object sender, RoutedEventArgs e)
        {
            if (points >= 34000)
            {
                points -= 34000;
                qiqis += 1;
                Update();
                UpdateCSSim();
                Img_tall_qiqi.Visibility = Visibility.Visible;
            }
        }

        private void SpCar_bt_Click(object sender, RoutedEventArgs e)
        {
            if (points >= 3250000)
            {
                points -= 3250000;
                tanks += 1;
                Update();
                UpdateCSSim();
                Img_M36.Visibility = Visibility.Visible;
            }
        }

        private void Van_bt_Click(object sender, RoutedEventArgs e)
        {
            if (points >= 456000)
            {
                points -= 456000;
                dMasters += 1;
                Update();
                UpdateCSSim();
                Img_van228.Visibility = Visibility.Visible;
            }
        }

        private void Gachi_vol12_bt_Click(object sender, RoutedEventArgs e)
        {
            if (points >= 200000)
            {
                points -= 200000;
                Gachi_vol12_bt.Visibility = Visibility.Hidden;
                Update();
            }

        }

        private void Gachi_vol34_bt_Click(object sender, RoutedEventArgs e)
        {
            if (points >= 200000)
            {
                points -= 200000;
                Gachi_vol34_bt.Visibility = Visibility.Hidden;
                Update();
            }
        }

        private void Gachi_vol56_bt_Click(object sender, RoutedEventArgs e)
        {
            if (points >= 200000)
            {
                points -= 200000;
                Gachi_vol56_bt.Visibility = Visibility.Hidden;
                Update();
            }
        }*/

        private void Cb_Cars_Selected(object sender, SelectionChangedEventArgs e)
        {
            string c1 = "Qiqic";
            string c2 = "GTR";
            string c3 = "1128A";
            ComboBox comboBox = (ComboBox)sender;
            ComboBoxItem selectedItem = (ComboBoxItem)comboBox.SelectedItem;
            string item = selectedItem.Content.ToString();
            SpendBox.AppendText(item + Environment.NewLine);
            if (item.Contains(c1))
            {
                if (points >= (costs[0]))
                {
                    points -= costs[0];
                    Img_tall_qiqi.Visibility = Visibility.Visible;
                    qiqis += 1;
                    //Update();
                    //UpdateCSSim();
                }
            }
            else if (item.Contains(c2))
            {
                if (points >= (costs[1]))
                {
                    points -= costs[1];
                    tanks += 1;
                    //Update();
                    //UpdateCSSim();
                    Img_M36.Visibility = Visibility.Visible;
                }
            }
            else if (item.Contains(c3))
            {
                if (points >= (costs[2]))
                {
                    points -= costs[2];
                    dMasters += 1;
                    //Update();
                    //UpdateCSSim();
                    Img_van228.Visibility = Visibility.Visible;
                }
            }
            Update();
        }

        private void Cb_Films_Selected(object sender, SelectionChangedEventArgs e)
        {
            string c1 = "1-2";
            string c2 = "3-4";
            string c3 = "5-6";
            ComboBox comboBox = (ComboBox)sender;
            ComboBoxItem selectedItem = (ComboBoxItem)comboBox.SelectedItem;
            string item = selectedItem.Content.ToString();
            SpendBox.AppendText(item + Environment.NewLine);
            if (item.Contains(c1))
            {
                if (points >= (films[0]))
                {
                    points -= films[0];
                    MessageBox.Show("Фильмы GM 1 и 2 куплены.");
                }
            }
            else if (item.Contains(c2))
            {
                if (points >= (films[1]))
                {
                    points -= films[1];
                    MessageBox.Show("Фильмы GM 3 и 4 куплены.");
                }
            }
            else if (item.Contains(c3))
            {
                if (points >= (films[2]))
                {
                    points -= films[2];
                    MessageBox.Show("Фильмы GM 5 и 6 куплены.");
                }
            }
            Update();
        }
    }
}
