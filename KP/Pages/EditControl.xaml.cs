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

namespace KP.Pages
{
    /// <summary>
    /// Логика взаимодействия для EditControl.xaml
    /// </summary>
    public partial class EditControl : Page
    {
        public EditControl()
        {
            InitializeComponent();
        }

        private void RaspisanieManagment(object sender, RoutedEventArgs e)
        {
            Redaktor.Content = new RaspisanieControl();
        }

        private void GruppaManagment(object sender, RoutedEventArgs e)
        {
            Redaktor.Content = new GruppaControl(true);
        }

        private void EDIT_Prepodavateli(object sender, RoutedEventArgs e)
        {
            Redaktor.Content = new EDIT_Prepodavateli(true);
        }

        private void EDIT_Auditorii(object sender, RoutedEventArgs e)
        {
            Redaktor.Content = new EDIT_Auditorii(true);
        }

        private void EDIT_Disciplina(object sender, RoutedEventArgs e)
        {
            Redaktor.Content = new EDIT_Disciplina(true);
        }

        private void AnalizManagment(object sender, RoutedEventArgs e)
        {
            Redaktor.Content = new AnalizControl(true);
        }

        private void EDIT_users(object sender, RoutedEventArgs e)
        {
            Redaktor.Content = new EDIT_users();
        }
    }
}
