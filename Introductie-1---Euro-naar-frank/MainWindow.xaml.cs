using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Introductie_1___Euro_naar_frank;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void calculateButton_Click(object sender, RoutedEventArgs e)
    {
        const double ExchangeRate = 40.3399;

        //Lees de waarde uit eurTextBox, converteer naar kommagetal (double) en bewaar in variabele eur
        //string input = eurTextBox.Text;
        //double eur = double.Parse(input);
        double eur = double.Parse(eurTextBox.Text);
        double bef = eur * ExchangeRate;

        //Toon de waarde van variabele bef in befTextBox
        //befTextBox.Text = bef.ToString();
        //befTextBox.Text = $"{bef:N2}";
        befTextBox.Text = bef.ToString("N2"); //N2: 2 decimalen
    }

    private void clearButton_Click(object sender, RoutedEventArgs e)
    {
        //Maak de inhoud van eurTextBox en befTextBox leeg
        eurTextBox.Clear();     // eurTextBox.Text = String.Empty;
        befTextBox.Clear();     // befTextBox.Text = String.Empty;

        //Verplaats de cursor (focus) naar eurTextBox
        eurTextBox.Focus();
    }
}