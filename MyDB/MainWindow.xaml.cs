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
 using System.Data.SqlClient;

namespace MyDB
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

        private void SignInButton_Clik(object sender, RoutedEventArgs e)
        {
            SqlConnection connection = new SqlConnection();
            SqlConnectionStringBuilder stringBuilder = new SqlConnectionStringBuilder();

            string severN, logN, passwordN;
            if (server.Text == "sql")
            {
                severN = server.Text;
                stringBuilder["Data Source"] = severN;
            }
            else
            {
                MessageBox.Show("Не правильно ввели имя сервера");
            }
            if (log.Text == "1")
            {
                logN = log.Text;
                stringBuilder["User ID"] = logN;
            }
            else
            {
                MessageBox.Show("Не правильно ввели имя пользователя");
            }
            if (password.Text == "123")
            {
                passwordN = password.Text;
                stringBuilder["Password"] = passwordN;
            }
            else
            {
                MessageBox.Show("Не правильно ввели пароль");
            }

            stringBuilder["Integrated Security"] = true;
            stringBuilder["Initial Catalog"] = "MyDB1";
            stringBuilder["MultipleActiveResultSets"] = true;
          
           connection.ConnectionString = stringBuilder.ConnectionString;
          
        }
    }
}
