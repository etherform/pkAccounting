using GalaSoft.MvvmLight;
using MaterialDesignThemes.Wpf;
using pkAccounting.usercontrols;
using pkAccounting.Viewmodels.Items;
using System;
using System.Collections.ObjectModel;

namespace pkAccounting.Viewmodels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public ObservableCollection<MenuItem> KontragentMenu { get; set; }
        public ObservableCollection<MenuItem> TovarMenu { get; set; }
        public ObservableCollection<MenuItem> SalesMenu { get; set; }
        public ObservableCollection<MenuItem> AnalyticsMenu { get; set; }
        public MenuItem SelectedMenu { get; set; }

        public MainWindowViewModel(ISnackbarMessageQueue snackbarMessageQueue) {
            KontragentMenu = GenerateMenuOne(snackbarMessageQueue);
            TovarMenu = GenerateMenuTwo(snackbarMessageQueue);
            SalesMenu = GenerateMenuThree(snackbarMessageQueue);
            AnalyticsMenu = GenerateMenuFour(snackbarMessageQueue);
        }

        private ObservableCollection<MenuItem> GenerateMenuOne(ISnackbarMessageQueue snackbarMessageQueue) {
            if (snackbarMessageQueue == null)
                throw new ArgumentNullException(nameof(snackbarMessageQueue));

            return new ObservableCollection<MenuItem> {
                new MenuItem("Договоры", new Dogovor { DataContext = new GridViewModel() }),
                new MenuItem("Доп. соглашения", new Dogovor { DataContext = new GridViewModel() }),
                new MenuItem("Заявки на поступление", new Dogovor { DataContext = new GridViewModel() }),
                new MenuItem("Заявки на перемещение", new Dogovor { DataContext = new GridViewModel() }),
                new MenuItem("Заявки на отгрузку", new Dogovor { DataContext = new GridViewModel() })
            };
        
        }
        private ObservableCollection<MenuItem> GenerateMenuTwo(ISnackbarMessageQueue snackbarMessageQueue) {
            if (snackbarMessageQueue == null)
                throw new ArgumentNullException(nameof(snackbarMessageQueue));

            return new ObservableCollection<MenuItem> {
                new MenuItem("Ж/Д накладные", new Dogovor { DataContext = new GridViewModel() }),
                new MenuItem("Слив автоцистерн", new Dogovor { DataContext = new GridViewModel() }),
                new MenuItem("Перемещения между складами", new Dogovor { DataContext = new GridViewModel() }),
                new MenuItem("Поступления на суда", new Dogovor { DataContext = new GridViewModel() }),
            };

        }
        private ObservableCollection<MenuItem> GenerateMenuThree(ISnackbarMessageQueue snackbarMessageQueue) {
            if (snackbarMessageQueue == null)
                throw new ArgumentNullException(nameof(snackbarMessageQueue));

            return new ObservableCollection<MenuItem> {
                new MenuItem("Реализация со склада", new Dogovor { DataContext = new GridViewModel() }),
                new MenuItem("Бункеровки", new Dogovor { DataContext = new GridViewModel() }),
            };

        }
        private ObservableCollection<MenuItem> GenerateMenuFour(ISnackbarMessageQueue snackbarMessageQueue) {
            if (snackbarMessageQueue == null)
                throw new ArgumentNullException(nameof(snackbarMessageQueue));

            return new ObservableCollection<MenuItem> {
                new MenuItem("Остатки на складах", new Dogovor { DataContext = new GridViewModel() }),
            };

        }
    }
}
