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

namespace lab3
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (!int.TryParse(textbox.Text, out int number)) MessageBox.Show("Поле только для числа");
            int didit1 = number / 100;
            int didit2 = (number % 100) / 100;
            int didit3 = number % 10;
            int sum = didit1 + didit2 + didit3;
            int product = didit1 * didit2 * didit3;
            answer1.Text += sum;
            answer.Text += product;
        }
    }
}
