using Kursach.Entities;
using System;
using System.Linq;
using System.Windows;

namespace Kursach
{
    /// <summary>
    /// Логика взаимодействия для AddEditWin.xaml
    /// </summary>
    public partial class AddWin : Window
    {

        private ShowroomEntities db = new ShowroomEntities();
        private Tovari newTovari;

        public AddWin()
        {
            InitializeComponent();
            ComboSizes.ItemsSource = db.Sizes.ToList();
            
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            string code = TextBoxCode.Text;             
            string name = TextBoxName.Text;
            string price = TextBoxPrice.Text;

            if (TextBoxCode.Text != "" && TextBoxName.Text != "" && ComboSizes.SelectedItem != null && TextBoxPrice.Text != "" )
            {
                var sizeSelect = db.Sizes.FirstOrDefault(s => s.Name == ComboSizes.Text);
                newTovari = new Tovari()
                {
                    IDTovara = Guid.NewGuid(),
                    TovarCode = code,
                    Name = name,
                    SizesCode = sizeSelect.IDSize,
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
