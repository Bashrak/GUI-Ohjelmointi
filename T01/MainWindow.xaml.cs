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
using System.Diagnostics;

namespace T01
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
        private void btnBuy_Click(object sender, RoutedEventArgs e)
        {
             
            string s = " ";
            txtShopping.Text = " ";
            foreach (object control in mySp.Children)
            {
                if (control is CheckBox)
                {
                    CheckBox checBox = (CheckBox)control;
                    if ((bool)checBox.IsChecked) s += checBox.Content + " ";
                }
              }
                 txtShopping.Text += s;
        }
    }

}

