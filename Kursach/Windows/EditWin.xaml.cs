using Kursach.Entities;
using System;
using System.Linq;
using System.Windows;

namespace Kursach
{
    /// <summary>
    /// Логика взаимодействия для EditWin.xaml
    /// </summary>
    public partial class EditWin : Window
    {
        private ShowroomEntities db = new ShowroomEntities();
        private Tovari tovariForUpdate;
 
        public EditWin(Tovari tovaryForEdit)
        {
            InitializeComponent();
            tovariForUpdate = tovaryForEdit;
            TextBoxCode.Text = tovariForUpdate.TovarCode.ToString();
            TextBoxName.Text = tovariForUpdate.Name.ToString();
            TextBoxPrice.Text = tovariForUpdate.Price.ToString();
            var sizes = db.Sizes.ToList();
            ComboSizes.ItemsSource = sizes;
            foreach (var size in sizes)
            {
                if ((size.IDSize == tovariForUpdate.SizesCode) != true)
                {
                    ComboSizes.SelectedItem = size;
                }
            }
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            if (TextBoxCode.Text != "" && TextBoxName.Text != "" && ComboSizes.SelectedItem != null && TextBoxPrice.Text != "")
            {
                var sizeSelect = db.Sizes.FirstOrDefault(s => s.Name == ComboSizes.Text);
                var tovar = db.Tovari.Find(tovariForUpdate.IDTovara);
                if(tovar != null)
                {
                    tovar.TovarCode = TextBoxCode.Text;
                    tovar.Name = TextBoxName.Text;
                    tovar.SizesCode = sizeSelect.IDSize;
                    tovar.Price = TextBoxPrice.Text;
                }

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
