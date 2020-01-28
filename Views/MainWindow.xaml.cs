using System.Windows;

namespace pkAccounting.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow() {
            MaterialDesignWindow.RegisterCommands(this);
            InitializeComponent();
        }
    }
}
