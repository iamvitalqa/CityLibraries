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
    /// Логика взаимодействия для ReadersPage.xaml
    /// </summary>
    public partial class ReadersPage : Page
    {
        public ReadersPage()
        {
            InitializeComponent();
            var currentReaders = Evdokimov_СityLibrariesEntities.GetContext().READERS.ToList();
            ReadersListView.ItemsSource = currentReaders;
            filterCBox.SelectedIndex = 0;
            rbuttonUp.IsChecked = true;
        }


        private void UpdateReaders()
        {
            var currentReaders = Evdokimov_СityLibrariesEntities.GetContext().READERS.ToList();
            currentReaders = currentReaders.Where(p => (p.READER_SURNAME.ToLower().Contains(searchTBox.Text.ToLower()) || (p.READER_NAME.ToLower().Contains(searchTBox.Text.ToLower()) || (p.READER_PATRONYMIC != null && p.READER_PATRONYMIC.ToLower().Contains(searchTBox.Text.ToLower()))))).ToList();
            int readersCount = currentReaders.Count;
            if (rbuttonDown.IsChecked.Value)
            {
                currentReaders = currentReaders.OrderByDescending(p => p.READER_AGE).ToList();
            }
            if (rbuttonUp.IsChecked.Value)
            {
                currentReaders = currentReaders.OrderBy(p => p.READER_AGE).ToList();
            }


            if (filterCBox.SelectedIndex == 0)
            {
                currentReaders = currentReaders.Where(p => (p.READER_AGE >= 1 && p.READER_AGE <= 100)).ToList();
            }
            if (filterCBox.SelectedIndex == 1)
            {
                currentReaders = currentReaders.Where(p => (p.READER_AGE >= 18 && p.READER_AGE <= 100)).ToList();
            }
            if (filterCBox.SelectedIndex == 2)
            {
                currentReaders = currentReaders.Where(p => (p.READER_AGE >= 7 && p.READER_AGE <= 17)).ToList();
            }
            if (filterCBox.SelectedIndex == 3)
            {
                currentReaders = currentReaders.Where(p => (p.READER_AGE >= 1 && p.READER_AGE <= 6)).ToList();
            }

            TBCount.Text = currentReaders.Count.ToString();
            TBALLRecords.Text = readersCount.ToString();

            ReadersListView.ItemsSource = currentReaders;

        }



        private void EditButton_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new AddEditPage((sender as Button).DataContext as READERS));
        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new AddEditPage(null));
        }

        private void searchTBox_SelectionChanged(object sender, RoutedEventArgs e)
        {
            UpdateReaders();
        }

        private void filterCBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UpdateReaders();
        }

        private void rbuttonUp_Checked(object sender, RoutedEventArgs e)
        {
            UpdateReaders();
        }

        private void rbuttonDown_Checked(object sender, RoutedEventArgs e)
        {
            UpdateReaders();
        }

        private void deleteButton_Click(object sender, RoutedEventArgs e)
        {
            var currentAgent = (sender as Button).DataContext as READERS;
            var currentAgentDefence = Evdokimov_СityLibrariesEntities.GetContext().ISSUING_LITERATURE.ToList();

            currentAgentDefence = currentAgentDefence.Where(p => p.ISSUING_LITERATURE_READER == currentAgent.READER_ID ).ToList();
            if (currentAgentDefence.Count != 0)
                MessageBox.Show("Невозможно выполнить удаление, т.к. читателю выдана книга");
            else
            {

                if (MessageBox.Show("Вы точно хотите выполнить удаление?", "Внимание!", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                {
                    try
                    {
                        Evdokimov_СityLibrariesEntities.GetContext().READERS.Remove(currentAgent);
                        Evdokimov_СityLibrariesEntities.GetContext().SaveChanges();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString());
                    }
                }
                    
            }
        }

        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (Visibility == Visibility.Visible)
            {
                Evdokimov_СityLibrariesEntities.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
                ReadersListView.ItemsSource = Evdokimov_СityLibrariesEntities.GetContext().READERS.ToList();
            }
        }
    }
}
