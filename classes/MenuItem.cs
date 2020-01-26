using System;
using System.ComponentModel;


namespace pkAccounting.classes
{
    class MenuItem : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private string _name;
        private object _content;
        
        public MenuItem(string name, object content) {
            _name = name;
            Content = content;
        }
        public string Name {
            get { return _name; }
            set { this.MutateVerbose(ref _name, value, RaisePropertyChanged()); }
        }
        public object Content {
            get { return _content; }
            set { this.MutateVerbose(ref _content, value, RaisePropertyChanged()); }
        }
        private Action<PropertyChangedEventArgs> RaisePropertyChanged() {
            return args => PropertyChanged?.Invoke(this, args);
        }

    }
}
