using MaterialDesignThemes.Wpf;
using pkAccounting.classes;
using pkAccounting.window;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;


namespace pkAccounting
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static Snackbar Snackbar;

        public MainWindow() {
            MaterialDesignWindow.RegisterCommands(this);
            InitializeComponent();

            Task.Factory.StartNew(() => {
                Thread.Sleep(2500);
            }).ContinueWith(t => {
                //note you can use the message queue from any thread, but just for the demo here we 
                //need to get the message queue from the snackbar, so need to be on the dispatcher
                MainSnackbar.MessageQueue.Enqueue("Welcome to Material Design In XAML Toolkit");
            }, TaskScheduler.FromCurrentSynchronizationContext());

            DataContext = new MainWindowViewModel(MainSnackbar.MessageQueue);

        }


    }
}
