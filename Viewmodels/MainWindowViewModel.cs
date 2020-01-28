using pkAccounting.Events;
using Prism.Events;

namespace pkAccounting.ViewModels
{
    public class MainWindowViewModel : BaseViewModel
    {
        public MainWindowViewModel(IEventAggregator ea) : base(ea)
        {
            Title = Title + " (Home)";
            _ea.GetEvent<SnackbarMsg>().Publish("Welcome to the Application");
        }
        
    }
}
