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

namespace HW3v2
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

        private void pigLatinButton_Click(object sender, RoutedEventArgs e)
        {
            string first = firstNameTextBox.Text , last = lastNameTextBox.Text, pigLatin_first, pigLatin_last, pigLatin_name;

            pigLatin_first = first.Substring(1, 1).ToUpper() + first.Substring(2) + first.Substring(0, 1).ToLower() + "ay";

            pigLatin_last = last.Substring(1, 1).ToUpper() + last.Substring(2) + last.Substring(0, 1).ToLower() + "ay";

            pigLatin_name = pigLatin_first + " " + pigLatin_last;

            Console.WriteLine("{0} in Pig Latin : {1} ", first + " " + last, pigLatin_name);

            MessageBox.Show(" "+ first + " " + last + "in Pig Latin :  "+ pigLatin_name);
        }
    }
}
