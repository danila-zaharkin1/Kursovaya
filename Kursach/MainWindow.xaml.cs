﻿using System;
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

        

        private void Button_Enter_Click(object sender, RoutedEventArgs e)
        {
            new Window2().Show();
            Hide();
        }


        private void TextBoxEmail_GotFocus(object sender, RoutedEventArgs e)
        {
            if (TextBoxEmail.Text != "Введите почту...") return;
            TextBoxEmail.Text = "";
            TextBoxEmail.Foreground = new SolidColorBrush(Colors.Black);
        }

        private void TextBoxEmail_LostFocus(object sender, RoutedEventArgs e)
        {
            if (TextBoxEmail.Text != "") return;
            TextBoxEmail.Text = "Введите почту...";
            TextBoxEmail.Foreground = new SolidColorBrush(Color.FromRgb(220, 220, 220));
        }

        private void TextBoxPassword_GotFocus(object sender, RoutedEventArgs e)
        {
            if (TextBoxPassword.Text != "Введите пароль...") return;
            TextBoxPassword.Text = "";
            TextBoxPassword.Foreground = new SolidColorBrush(Colors.Black);
        }

        private void TextBoxPassword_LostFocus(object sender, RoutedEventArgs e)
        {
            if (TextBoxPassword.Text != "") return;
            TextBoxPassword.Text = "Введите пароль...";
            TextBoxPassword.Foreground = new SolidColorBrush(Color.FromRgb(220, 220, 220));
        }

       
    }
}
