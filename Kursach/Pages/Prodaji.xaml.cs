using Kursach.Entities;
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
    /// Логика взаимодействия для Prodaji.xaml
    /// </summary>
    public partial class Prodaji : Page
    {
        public Prodaji()
        {
            InitializeComponent();
            ProdajiiList.ItemsSource = new ShowroomEntities().Sells.ToList();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Tovary());
        }

        private void But_exit_Click_1(object sender, RoutedEventArgs e)
        {
            new MainWindow().Show();
            Window window = Window.GetWindow(this);
            window.Close();
        }

        
    }
}
