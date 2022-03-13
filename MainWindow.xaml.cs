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

namespace ExamTraining
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<User> DatabaseUsers { get; private set; }

        public MainWindow()
        {
            InitializeComponent();
        }

        public void Create()
        {
            using (DataContext context = new DataContext())
            {
                var firstname = FirstnameTextBox.Text;
                var insertion = InsertionTextBox.Text;
                var lastname = LastnameTextBox.Text;
                var description = DescriptionTextBox.Text;
                var school = SchoolTextBox.Text;

                if (firstname != null && insertion != null && lastname != null && description != null && school != null)
                {
                    context.Users.Add(new User() { Firstname = firstname, Insertion = insertion, Lastname = lastname, Description = description, School = school });
                    context.SaveChanges();
                }

            }
        }
        public void Read()
        {
            using (DataContext context = new DataContext())
            {
                DatabaseUsers = context.Users.ToList();
                ItemList.ItemsSource = DatabaseUsers;
            }
        }
        public void Update()
        {


            using (DataContext context = new DataContext())
            {

                User selectedUser = ItemList.SelectedItem as User;

                var firstname = FirstnameTextBox.Text;
                var insertion = InsertionTextBox.Text;
                var lastname = LastnameTextBox.Text;
                var description = DescriptionTextBox.Text;
                var school = SchoolTextBox.Text;

                if (firstname != null && insertion != null && lastname != null && description != null && school != null)
                {

                    User user = context.Users.Find(selectedUser.Id);
                        user.Firstname = firstname;
                        user.Insertion = insertion;
                        user.Lastname = lastname;
                        user.Description = description;
                        user.School = school;

                    context.SaveChanges();
                }

            }
        }
        public void Delete()
        {

            using (DataContext context = new DataContext())
            {

                User selectedUser = ItemList.SelectedItem as User;

                if (selectedUser != null)
                {
                    User user = context.Users.Single(x=> x.Id == selectedUser.Id);

                    context.Remove(user);
                    context.SaveChanges();

                }


            }

        }
        private void HomeButton_Click(object sender, RoutedEventArgs e)
        {
            SecondWindow secondWindow = new SecondWindow();
            secondWindow.Show();
            Close();
        }
        private void AboutButton_Click(object sender, RoutedEventArgs e)
        {
            SecondWindow secondWindow = new SecondWindow();
            secondWindow.Show();
            Close();
        }
        private void ContactButton_Click(object sender, RoutedEventArgs e)
        {
            SecondWindow secondWindow = new SecondWindow();
            secondWindow.Show();
            Close();
        }

        private void CreateButton_Click(object sender, RoutedEventArgs e)
        {
            Create();   
        }

        private void ReadButton_Click(object sender, RoutedEventArgs e)
        {
            Read();
        }

        private void UpdateButton_Click(object sender, RoutedEventArgs e)
        {
            Update();
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            Delete();
        }
        private void MenuItemDelete_Click(object sender, RoutedEventArgs e)
        {
            Delete();
        }private void MenuItemRead_Click(object sender, RoutedEventArgs e)
        {
            Read();
        }private void MenuItemClose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void EnableCheckBox_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void FirstnameTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void InsertionTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        private void LastnameTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        private void DescriptionTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void SchoolTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

    }
}

