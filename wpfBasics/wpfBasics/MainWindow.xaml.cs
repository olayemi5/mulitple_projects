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

namespace wpfBasics
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

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        string connect = @"Data Source=USER-PC\SQLEXPRESS;Initial Catalog=BasisSAVE;Integrated Security=True";
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            SqlConnection con = new SqlConnection(connect);

            using (con)
                try 
                {
                    
                    con.Open();

                    string Query = "insert into BioDetails (Description,Status,Part_Number,Material,Mass,Finished,PurchasedInfo) values('"+ this.Decription.Text+"','"+this.Status1.Text + "','"+ this.part.Text + "','"+ this.Material.Text + "','"+ this.Mass.Text + "','"+ this.Finshed.Text + "','"+ this.Info.Text + "')";

                    SqlCommand cmd = new SqlCommand(Query,con);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Saved");


                }
                catch(SqlException x) 
                
                {
                    Console.WriteLine(x.Message);
                }
                
        }
    }
}
