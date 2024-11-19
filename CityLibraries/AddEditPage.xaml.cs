using Microsoft.Win32;
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

namespace CityLibraries
{
    /// <summary>
    /// Логика взаимодействия для AddEditPage.xaml
    /// </summary>
    public partial class AddEditPage : Page
    {
        private READERS currentREADERS = new READERS();
        public AddEditPage(READERS SelectedREADERS)
        {
            InitializeComponent();
            if (SelectedREADERS != null)
            {
                currentREADERS = SelectedREADERS;
               
            }
            DataContext = currentREADERS;
        }
        private void ChangePictureBtn_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog myOpenFileDialog = new OpenFileDialog();
            if (myOpenFileDialog.ShowDialog() == true)
            {
                currentREADERS.READER_PHOTO = myOpenFileDialog.FileName;
                LogoImage.Source = new BitmapImage(new Uri(myOpenFileDialog.FileName));
            }
        }
        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.GoBack();
        }
        private void saveButton_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();
            if (string.IsNullOrWhiteSpace(currentREADERS.READER_SURNAME))
                errors.AppendLine("Укажите фамилию читателя!");
            if (string.IsNullOrWhiteSpace(currentREADERS.READER_NAME))
                errors.AppendLine("Укажите имя читателя!");
            if (string.IsNullOrWhiteSpace(currentREADERS.READER_PATRONYMIC))
                errors.AppendLine("Укажите отчество читателя!");
            if (string.IsNullOrWhiteSpace(currentREADERS.READER_BIRTHDAY.ToString()))
                errors.AppendLine("Укажите дату рождения читателя!");
            if (string.IsNullOrWhiteSpace(currentREADERS.READER_WORKING_PLACE))
                errors.AppendLine("Укажите место учёбы/работы читателя!");
            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }
            if (currentREADERS.READER_ID == 0)
            {
               Evdokimov_СityLibrariesEntities.GetContext().READERS.Add(currentREADERS);
            }
            try
            {
                Evdokimov_СityLibrariesEntities.GetContext().SaveChanges();
                MessageBox.Show("Информация сохранена");
                Manager.MainFrame.GoBack();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
