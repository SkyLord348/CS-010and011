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

namespace ifElseStatementsLPB
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

        private void buttonOK_Click(object sender, RoutedEventArgs e)
        {

            //labelAnswer.Content = "";

            //if (textBoxOne.Text == textBoxTwo.Text)
            //{

            //    labelAnswer.Content = "They are equal!!";

            //}
            //else
            //{

            //    labelAnswer.Content = "They are not equal!!";

            //}

            //if (checkBoxHungry.IsChecked == true)
            //{

            //    labelAnswer.Content = "Then go get some food.";


            //}
            //else
            //{

            //    labelAnswer.Content = "Good job for feeding yourself.";

            //}

            if (radioButtonSteak.IsChecked == true)
            {

                labelAnswer.Content = "You must be a great person like me!!";

            }
            else if (radioButtonPizza.IsChecked == true)
            {

                labelAnswer.Content = "You must be from St. Louis!";

            }
            else if (radioButtonSalad.IsChecked == true)
            {

                labelAnswer.Content = "You must be healthy!!";

            }






        }
    }
}
