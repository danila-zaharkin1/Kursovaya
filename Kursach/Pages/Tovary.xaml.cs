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
    /// Логика взаимодействия для Tovari.xaml
    /// </summary>
    public partial class Tovary: Page
    {
        private ShowroomEntities db = new ShowroomEntities();
        private Tovari tovariForDelete;
        
        public Tovary()
        {
            InitializeComponent();
            TovariList.ItemsSource = new ShowroomEntities().Tovari.ToList();
        }        

        private void But_exit_Click(object sender, RoutedEventArgs e)
        {
            new MainWindow().Show();
            Window window = Window.GetWindow(this);
            window.Close();
        }
                
        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            new AddWin().ShowDialog();
        }

        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            var selectedItem = TovariList.SelectedItem as Tovari;
            if (selectedItem != null)
            {
                Tovari itemToDelete = db.Tovari.FirstOrDefault(t => t.IDTovara == selectedItem.IDTovara);
                if (itemToDelete != null)
                {
                    db.Tovari.Remove(itemToDelete);
                    db.SaveChanges();
                }
            }
            MessageBox.Show("Товар успешно удален");
            TovariList.ItemsSource = new ShowroomEntities().Tovari.ToList();
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            new AddWin().ShowDialog();
            TovariList.ItemsSource = new ShowroomEntities().Tovari.ToList();
        }

        private void BtnProdaji_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Prodaji());
        }

        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {

        }

        private void BtnSell_Click(object sender, RoutedEventArgs e)
        {

        }

        
    }
}
