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

namespace loger
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

        private void Close(object sender, MouseButtonEventArgs e)
        {
            try 
            {
                this.Close();
            }
            catch (Exception x) 
            {
                MessageBox.Show(x.Message);
            }
        }

        private void MinimizeApp(object sender, MouseButtonEventArgs e)
        {
            try
            {
                this.WindowState = WindowState.Minimized;
               
            }
             catch (Exception x) 
            {
                MessageBox.Show(x.Message);         
            }
        }

        private void Maximize(object sender, MouseButtonEventArgs e)
        {
            try
            {
                this.WindowState = WindowState.Maximized;
               
            }
            catch (Exception x) 
            {
                MessageBox.Show(x.Message);
            }
        }


        private void Islogin(object sender, MouseButtonEventArgs e)
        {

        }
       
    }
}
