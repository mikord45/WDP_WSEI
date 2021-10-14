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

namespace HelloWPFApp
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void textBoxImie_LostFocus(object sender, RoutedEventArgs e)
        {
            labelKomunikat1.Content = $"Witaj {textBoxImie.Text} {textBoxNazwisko.Text}!";
        }

        private void textBoxNazwisko_LostFocus(object sender, RoutedEventArgs e)
        {
            labelKomunikat1.Content = $"Witaj {textBoxImie.Text} {textBoxNazwisko.Text}!";
        }

        private void textBoxWiek_LostFocus(object sender, RoutedEventArgs e)
        {
            int wiek = Convert.ToInt32(textBoxWiek.Text);
            if(wiek < 67)
            {
                labelKomunikat2.Content = $"Do emerytury zostało ci {67 - wiek}";
            }
            else
            {
                labelKomunikat2.Content = "Jesteś emerytem";
            }
        }

        private void buttonClear_Click(object sender, RoutedEventArgs e)
        {
            textBoxImie.Text = "";
            textBoxNazwisko.Text = "";
            textBoxWiek.Text = "";
            labelKomunikat1.Content = "";
            labelKomunikat2.Content = "";
        }
    }
}
