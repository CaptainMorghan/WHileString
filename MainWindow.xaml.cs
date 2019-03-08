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

namespace while_string
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            string myword = "sit on my face and tell me that you love me";
            string output = "";
            while (myword.Length >0)
            {
                output += myword.Substring(0, 1) + Environment.NewLine;
                myword = myword.Substring(1);
            }
            lblOutput.Content = output;
        }
    }
}
