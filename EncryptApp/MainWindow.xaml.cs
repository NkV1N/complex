using EncryptApp.Models;
using EncryptApp.Views;
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

namespace EncryptApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var cezar = new Cezar()
            {
                Key = 5,
            };
        }

        private void mainButton_Checked(object sender, RoutedEventArgs e)
        {
            frameView.Navigate(new MainView());
        }

        private void cezarButton_Checked(object sender, RoutedEventArgs e)
        {
            frameView.Navigate(new CezarView());
        }

        private void simpleButton_Checked(object sender, RoutedEventArgs e)
        {
            frameView.Navigate(new SimpleSubstitutionPage());
        }

        private void complexButton_Checked(object sender, RoutedEventArgs e)
        {
            frameView.Navigate(new ComplexSubstitutionPage());
        }

        private void stirlitzButton_Checked(object sender, RoutedEventArgs e)
        {
            frameView.Navigate(new StirlitzPage());
        }

        private void visionaryButton_Checked(object sender, RoutedEventArgs e)
        {
            frameView.Navigate(new Visionary());
        }

        private void asciiButton_Checked(object sender, RoutedEventArgs e)
        {
            frameView.Navigate(new ASCIIСodePage());
        }

        private void alphabetButton_Checked(object sender, RoutedEventArgs e)
        {
            frameView.Navigate(new NumberInTheAlphabetPage());
        }

        private void keyboerdButton_Checked(object sender, RoutedEventArgs e)
        {
            frameView.Navigate(new ByKeyboardLayoutPage());
        }
    }
}
