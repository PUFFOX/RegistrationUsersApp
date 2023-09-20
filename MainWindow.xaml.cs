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

namespace RegistrationUsersApp
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

        private void btnRegUser_Click(object sender, RoutedEventArgs e)
        {
            //--------------перевірка на коректність 

            string login = textBoxLogin.Text.Trim(); //+пробели
            string pass = passBoxPass.Password.Trim(); //+пробели
            string pass2 = passBoxPass2.Password.Trim(); //+пробели
            string email = textBoxEmail.Text.ToLower(); //+регістр

            if (login.Length < 5)
            {
                textBoxLogin.ToolTip = "Некоректно!";
                textBoxLogin.Background = Brushes.DarkRed;
            }
            else if (pass.Length < 5)
            {
                passBoxPass.ToolTip = "Некоректно!";
                passBoxPass.Background = Brushes.DarkRed;
            }
            else if (pass != pass2)
            {
                passBoxPass2.ToolTip = "Некоректно!";
                passBoxPass2.Background = Brushes.DarkRed;
            }
            else if (email.Length < 5 || !email.Contains("@") || !email.Contains(".")) //проверка символа
            {
                textBoxEmail.ToolTip = "Некоректно!";
                textBoxEmail.Background = Brushes.DarkRed;
            }
            else
            {
                textBoxLogin.Text = "";
                textBoxLogin.Background = Brushes.Transparent; //прозрачно

                passBoxPass.Password = "";
                passBoxPass.Background = Brushes.Transparent; //прозрачно

                passBoxPass2.Password = "";
                passBoxPass2.Background = Brushes.Transparent; //прозрачно

                textBoxEmail.Text = "";
                textBoxEmail.Background = Brushes.Transparent; //прозрачно

                MessageBox.Show("Все гуд :)");

                

            }


        }
    }
}
