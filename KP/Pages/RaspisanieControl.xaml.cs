using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
    /// Логика взаимодействия для RaspisanieControl.xaml
    /// </summary>
    public partial class RaspisanieControl : Page
    {
        public RaspisanieControl()
        {
            InitializeComponent();
        }

        //private void LoadGroups()                     // Закоментировать Ctrl + K + C   Откоментировать Ctrl + K + U
        //{
        //    using (SqlConnection connection = new SqlConnection(connectionString))
        //    {
        //        connection.Open();
        //        SqlCommand command = new SqlCommand("SELECT GroupName FROM Groups", connection);
        //        SqlDataReader reader = command.ExecuteReader();

        //        while (reader.Read())
        //        {
        //            GroupComboBox.Items.Add(reader["GroupName"].ToString());
        //        }
        //    }
        //}

    }
}
