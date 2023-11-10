using Kursach.Entities;
using System;
using System.Linq;
using System.Windows;

namespace Kursach
{
    /// <summary>
    /// Логика взаимодействия для AddEditWin.xaml
    /// </summary>
    public partial class AddEditWin : Window
    {

        private ShowroomEntities db = new ShowroomEntities();
        private Tovari newTovari; 
        public AddEditWin()
        {
            InitializeComponent();
            ComboSizes.ItemsSource = db.Sizes.ToList();
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {

            string name = TextBoxName.Text;
            int size = ComboSizes.SelectedIndex;
            string price = TextBoxPrice.Text;

            if (TextBoxName.Text != "" && ComboSizes.SelectedItem != null && TextBoxPrice.Text != "" )
            {
                newTovari = new Tovari()
                {
                    ID = new Random().Next(0,100),
                    Name = name,
                    SizesCode = size,
                    Price = price
                };
                db.Tovari.Add(newTovari);
                db.SaveChanges();
                Close();
            }
            else
            {
                MessageBox.Show("Заполните все данные");
            }
            
        }
        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
