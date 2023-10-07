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

namespace Kursach
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



        private void TextBox1_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBoxPassword.Text = "";
        }

        private void TextBox2_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBoxEmail.Text = "";
        }

        private void Button_Enter_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Regist_Click(object sender, RoutedEventArgs e)
        {

        }

        private void TextBoxPassword_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBoxEmail_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBoxEmail_LostFocus(object sender, RoutedEventArgs e)
        {
            TextBoxEmail.Text = "Введите почту...";
        }

        private void TextBoxPassword_LostFocus(object sender, RoutedEventArgs e)
        {
            TextBoxPassword.Text = "Введите пароль...";
        }
    }
}
