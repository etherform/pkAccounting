using System.ComponentModel;
using MaterialDesignThemes.Wpf;
using pkAccounting.Events;
using Prism.Events;
using PropertyChanged;

namespace pkAccounting.ViewModels
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        [DoNotNotify]
        protected readonly IEventAggregator _ea;
        private static ISnackbarMessageQueue SnackQueue { get; } = new SnackbarMessageQueue();
        public string Title { get; set; }
        protected BaseViewModel(IEventAggregator ea)
        {
            Title = "Коммерческий учет";
            _ea = ea;
            _ea.GetEvent<SnackbarMsg>().Subscribe(OnSnackbarMessage);
        }
        
        private static void OnSnackbarMessage(string msg)
        {
            SnackQueue.Enqueue(msg);
        }
    }
}