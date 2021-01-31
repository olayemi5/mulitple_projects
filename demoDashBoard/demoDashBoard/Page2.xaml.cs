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

namespace demoDashBoard
{
    /// <summary>
    /// Interaction logic for Page2.xaml
    /// </summary>
    public partial class Page2 : Page
    {
        public Page2()
        {
            InitializeComponent();
        }

        string connect = @"Data Source=USER-PC\SQLEXPRESS;Initial Catalog=logInDetails;Integrated Security=True";
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection con = new SqlConnection(connect);
            con.Open();
            
            string Query = "INSERT INTO Apply(Description,Status,Address,Vardict,Materials,Mass,Length,WorkStatus,Info,ApplicantID) VALUES('"+this.Description.Text+"','"+this.Status.Text+"','"+this.Address.Text+"','"+this.Vardict.Text+"','"+this.Materials.Text+"',"+this.Mass.Text+","+this.Length.Text+",'"+this.Work.Text+"','"+this.Info.Text+"',"+this.AppID.Text+")";

            SqlCommand cmd = new SqlCommand(Query, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show(" SAVED \n Resubmission of data equals void!");
        }
    }
}
