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

namespace Kursach
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void TextBoxEmail_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBoxEmail.Text = "";
        }

        private void TextBoxEmail_LostFocus(object sender, RoutedEventArgs e)
        {
            TextBoxEmail.Text = "Введите почту...";
        }

        private void TextBoxEmail_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_SetUp_Click(object sender, RoutedEventArgs e)
        {

        }

        private void TextBoxPassword_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBoxPassword.Text = "";
        }

        private void TextBoxPassword_LostFocus(object sender, RoutedEventArgs e)
        {
            TextBoxPassword.Text = "Введите пароль...";
        }

        private void TextBoxConfirmPassword_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBoxConfirmPassword.Text = "";
        }

        private void TextBoxConfirmPassword_LostFocus(object sender, RoutedEventArgs e)
        {
            TextBoxConfirmPassword.Text = "Подтвердите пароль";
        }
    }
}
