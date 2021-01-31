using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Diagnostics;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.SqlClient;

namespace demoDashBoard
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        string connect = @"Data Source=USER-PC\SQLEXPRESS;Initial Catalog=logInDetails;Integrated Security=True";
        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            
            SqlConnection con = new SqlConnection(connect);
            using (con)
            {
                try
                {
                    con.Open();
                    
                    string Query = "SELECT COUNT(1) FROM UserAccess WHERE Username=@Username AND Password=@Password";
                    SqlCommand cmd = new SqlCommand(Query, con);
                    
                    cmd.Parameters.AddWithValue("@Username", Username.Text);
                    cmd.Parameters.AddWithValue("@Password", Password.Password);
                    
                   int count = Convert.ToInt32(cmd.ExecuteScalar());
                    if (count == 1) 
                    {
                        Dashboard dashboard = new Dashboard();
                        dashboard.Show();
                        this.Close();
                    }

                    else 
                    {
                        MessageBox.Show("Username or Password incorrect!");
                    }

                }
                
                catch(SqlException x)
                {
                    Console.WriteLine(x.Message);

                }finally 
                {
                    con.Close();
                }


            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
