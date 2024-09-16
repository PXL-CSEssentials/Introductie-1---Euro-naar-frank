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

        double eur = double.Parse(eurTextBox.Text);
        double bef = eur * ExchangeRate;

        //befTextBox.Text = bef.ToString();
        befTextBox.Text = bef.ToString("N2");
        //befTextBox.Text = $"{bef:N2}";
    }

    private void clearButton_Click(object sender, RoutedEventArgs e)
    {
        eurTextBox.Clear();     // eurTextBox.Text = String.Empty;
        befTextBox.Clear();     // befTextBox.Text = String.Empty;

        eurTextBox.Focus();
    }
}