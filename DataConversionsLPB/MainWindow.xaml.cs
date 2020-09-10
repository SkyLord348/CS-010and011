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

namespace DataConversionsLPB
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

        private void buttonGo_Click(object sender, RoutedEventArgs e)
        {
            /*
            int i;

            i = "125";
            */

            /*
            long j = 200000000000000000;

            int i;

            i = (int) j;

            labelOne.Content = i;
            */

            //double j = 2.55;

            //int i = (int) j;

            //labelOne.Content = i;

            string userInput = textBoxInput.Text;

            double numOne = double.Parse(userInput);

            double answer = numOne + 64;

            labelAnswer.Content = answer;




        }
    }
}
