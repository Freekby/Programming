using System.Windows;
using ContactCollection.ViewModel;

namespace ContactCollection;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        this.DataContext = new MainVM();
    }
}