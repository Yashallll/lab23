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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {


        public MainWindow()
        {

            InitializeComponent();
            TT.Content = "Сегодня: " + DateTime.Now.ToShortDateString() + " | Текущее время: " + DateTime.Now.ToLongTimeString();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void Make_Click(object sender, RoutedEventArgs e)
        {
            _1.Content = name.Text;
            _2.Content = Date.SelectedDate;
            _3.Content = Education.Text;
            if (Yes.IsChecked == true)
            {
                _4.Content = "Есть";
                double a = Convert.ToDouble(Work.Text);
                double eb = a / 100 * 3;
                double b = Convert.ToDouble(Time.Text);
                double c = a * b * 28 + eb;
                _8.Content = c;
            }
            else
            {
                _4.Content = "Нет";
                double a = Convert.ToDouble(Work.Text);
                double b = Convert.ToDouble(Time.Text);
                double c = a * b * 28;
                _8.Content = c;
            }
            _5.Content = Educat.Text;
            _6.Content = Work.Text;
            _7.Content = Time.Text;


        }

        private void Del_Click(object sender, RoutedEventArgs e)
        {
            _1.Content = "ФИО";
            _2.Content = "Дата рождения";
            _3.Content = "Образование";
            _4.Content = "Наличие ученой степени";
            _5.Content = "Дисциплина";
            _6.Content = "Стоимость 1 часа работы";
            _7.Content = "Недельная нагрузка";
            _8.Content = "Заработанная плата";
           

        }

        private void Escape_Click(object sender, RoutedEventArgs e)
        {
            Forma.Close();
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            border1.Background = Brushes.Black;
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           
            }

        private void Save_Click_1(object sender, RoutedEventArgs e)
        {
            string n = color1.Text;
            switch (n)
            {
                case "Голубой":
                    border1.Background = Brushes.Blue;
                    border2.Background = Brushes.Blue;
                    break;
                case "Черный":
                    border1.Background = Brushes.Black;
                    border2.Background = Brushes.Black;
                    break;
                case "Желтый":
                    border1.Background = Brushes.Yellow;
                    border2.Background = Brushes.Yellow;
                    break;
                case "Красный":
                    border1.Background = Brushes.Red;
                    border2.Background = Brushes.Red;
                    break;
                case "зелёный":
                    border1.Background = Brushes.Green;
                    border2.Background = Brushes.Green;
                    break;
                    
            }
        }
    }
    }
