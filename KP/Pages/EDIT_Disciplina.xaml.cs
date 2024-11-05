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
    /// Логика взаимодействия для EDIT_Disciplina.xaml
    /// </summary>
    public partial class EDIT_Disciplina : Page
    {
        public bool IsEditor { get; set; }
        public EDIT_Disciplina(bool isEditor)
        {
            InitializeComponent();
            IsEditor = isEditor;
            DataContext = this;
        }

        private void AddDisciplina_Click(object sender, RoutedEventArgs e)
        {

        }

        private void DeleteDiciplina_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
