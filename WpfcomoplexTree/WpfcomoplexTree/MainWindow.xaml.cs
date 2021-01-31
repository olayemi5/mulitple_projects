using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
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

namespace WpfcomoplexTree
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        #region Constructor
    /// <summary>
    /// Default Constructor
    /// </summary>
        public MainWindow()
        {
            InitializeComponent();
        }
        #endregion

        #region On loaded
        /// <summary>
        /// When the application first opens
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Window_Loaded(object sender, RoutedEventArgs e) 
        {
            foreach (var file in Directory.GetLogicalDrives())
            {
                var item = new TreeView();

                item.Tag = file;

                item.Items.Add(null);

                FolderView.Items.Add(item);
            }
        }

        #endregion
    }
}
