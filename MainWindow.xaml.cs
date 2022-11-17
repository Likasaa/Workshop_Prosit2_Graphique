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
using Workshop_Prosit2_Graphique.HelperMethods;

namespace Workshop_Prosit2_Graphique
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static Conversion Conversion = new Conversion();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void NameInputButton_Click(object sender, RoutedEventArgs e)
        {
            string name = MainTextBox.Text;
            string witness = "";
            string result = Conversion.Convert(name, witness);
            NameLabel.Content = name + " string transformed into " + result + " string";
        }
    }
}
