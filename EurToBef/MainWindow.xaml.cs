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

namespace EurToBef;

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
        const double exchangeRate = 40.3399;

        //Lees de waarde uit eurTextBox, converteer naar kommagetal (double) en bewaar in variabele eur
        double eur = double.Parse(eurTextBox.Text);

        //Bereken de waarde in BEF en bewaar in variabele bef
        double bef = eur * exchangeRate;

        //Toon de waarde van variabele bef in befTextBox
        //befTextBox.Text = bef.ToString();
        befTextBox.Text = bef.ToString("N2"); //N2: 2 decimalen
        //befTextBox.Text = $"{bef:N2}";
    }

    private void clearButton_Click(object sender, RoutedEventArgs e)
    {
        

        eurTextBox.Clear();     // eurTextBox.Text = String.Empty;
        befTextBox.Clear();     // befTextBox.Text = String.Empty;

        eurTextBox.Focus();
    }
}