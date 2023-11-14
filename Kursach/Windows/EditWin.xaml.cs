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
            TextBoxName.Text = tovaryForEdit.Name;
            ComboSizes.SelectedItem = tovaryForEdit.SizesCode;
            TextBoxPrice.Text = tovaryForEdit.Price;            
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            
        }
        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        
    }
}
