using System;
using System.ComponentModel;


namespace pkAccounting.Viewmodels.Items
{
    public class MenuItem : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public String Name { get; set; }
        public Object Content { get; set; }

        public MenuItem(String name, Object content)
        {
            Name = name;
            Content = content;
        }
    }
}
