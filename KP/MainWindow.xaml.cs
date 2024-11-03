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
using KP.DataBase;
using System.Data.SQLite;

namespace KP
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private const string ConnectionString = "Data Source=Ucheb_Raspisnie.db;Version=3;";
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Loggin_Button(object sender, RoutedEventArgs e)
        {

            if (ValidateLogin(LoginTextBox.Text, PasswordTextBox.Text))
            {
                MainMenu mainMenu = new MainMenu(false);
                mainMenu.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Введите логин и пароль!", "Ошибка!",MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private bool ValidateLogin(string login, string password)
        {
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();

                var command = new SQLiteCommand("SELECT * FROM Polzovateli WHERE LOGIN = @LOGIN AND PASSWORD = @PASSWORD", connection);
                command.Parameters.AddWithValue("@LOGIN", login);
                command.Parameters.AddWithValue("@PASSWORD", password);

                using (var reader = command.ExecuteReader())
                {
                    return reader.HasRows;
                }
            }
        }

        private void Guest_Button(object sender, RoutedEventArgs e)
        {
            MainMenu mainMenu = new MainMenu(true);
            mainMenu.Show();
            this.Close();
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
