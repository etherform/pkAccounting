using MaterialDesignThemes.Wpf;
using pkAccounting.usercontrols;
using pkAccounting.viewmodels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pkAccounting.classes
{
    class MainWindowViewModel : BaseViewModel {
        private ObservableCollection<MenuItem> _kontragentMenu;
        private ObservableCollection<MenuItem> _tovarMenu;
        private ObservableCollection<MenuItem> _salesMenu;
        private ObservableCollection<MenuItem> _analyticsMenu;
        private MenuItem _selectedItem;

        public MainWindowViewModel(ISnackbarMessageQueue snackbarMessageQueue) {
            _kontragentMenu = GenerateMenuOne(snackbarMessageQueue);
            _tovarMenu = GenerateMenuTwo(snackbarMessageQueue);
            _salesMenu = GenerateMenuThree(snackbarMessageQueue);
            _analyticsMenu = GenerateMenuFour(snackbarMessageQueue);
        }

        public ObservableCollection<MenuItem> KontragentMenu {
            get => _kontragentMenu;
            set => SetProperty(ref _kontragentMenu, value);
        }

        public ObservableCollection<MenuItem> TovarMenu {
            get => _tovarMenu;
            set => SetProperty(ref _tovarMenu, value);
        }

        public ObservableCollection<MenuItem> SalesMenu {
            get => _salesMenu;
            set => SetProperty(ref _salesMenu, value);
        }

        public ObservableCollection<MenuItem> AnalyticsMenu {
            get => _analyticsMenu;
            set => SetProperty(ref _analyticsMenu, value);
        }

        public MenuItem SelectedItem {
            get => _selectedItem;
            set => SetProperty(ref _selectedItem, value);
        }

        private ObservableCollection<MenuItem> GenerateMenuOne(ISnackbarMessageQueue snackbarMessageQueue) {
            if (snackbarMessageQueue == null)
                throw new ArgumentNullException(nameof(snackbarMessageQueue));

            return new ObservableCollection<MenuItem> {
                new MenuItem("Договоры", new Dogovor { DataContext = new DogovorViewModel() }),
                new MenuItem("Доп. соглашения", new Dogovor { DataContext = new DogovorViewModel() }),
                new MenuItem("Заявки на поступление", new Dogovor { DataContext = new DogovorViewModel() }),
                new MenuItem("Заявки на перемещение", new Dogovor { DataContext = new DogovorViewModel() }),
                new MenuItem("Заявки на отгрузку", new Dogovor { DataContext = new DogovorViewModel() })
            };
        
        }
        private ObservableCollection<MenuItem> GenerateMenuTwo(ISnackbarMessageQueue snackbarMessageQueue) {
            if (snackbarMessageQueue == null)
                throw new ArgumentNullException(nameof(snackbarMessageQueue));

            return new ObservableCollection<MenuItem> {
                new MenuItem("Ж/Д накладные", new Dogovor { DataContext = new DogovorViewModel() }),
                new MenuItem("Слив автоцистерн", new Dogovor { DataContext = new DogovorViewModel() }),
                new MenuItem("Перемещения между складами", new Dogovor { DataContext = new DogovorViewModel() }),
                new MenuItem("Поступления на суда", new Dogovor { DataContext = new DogovorViewModel() }),
            };

        }
        private ObservableCollection<MenuItem> GenerateMenuThree(ISnackbarMessageQueue snackbarMessageQueue) {
            if (snackbarMessageQueue == null)
                throw new ArgumentNullException(nameof(snackbarMessageQueue));

            return new ObservableCollection<MenuItem> {
                new MenuItem("Реализация со склада", new Dogovor { DataContext = new DogovorViewModel() }),
                new MenuItem("Бункеровки", new Dogovor { DataContext = new DogovorViewModel() }),
            };

        }
        private ObservableCollection<MenuItem> GenerateMenuFour(ISnackbarMessageQueue snackbarMessageQueue) {
            if (snackbarMessageQueue == null)
                throw new ArgumentNullException(nameof(snackbarMessageQueue));

            return new ObservableCollection<MenuItem> {
                new MenuItem("Остатки на складах", new Dogovor { DataContext = new DogovorViewModel() }),
            };

        }
    }
}
