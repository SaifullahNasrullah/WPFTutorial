using System.Collections.ObjectModel;
using WPFTutorial12.Model;
using WPFTutorial12.MVVM;

namespace WPFTutorial12.ViewModel
{
    internal class MainWindowViewModel : ViewModelBase
    {
        public ObservableCollection<Item> Items { get; set; }

        public RelayCommand AddCommand => new RelayCommand(execute => AddItem());
        public RelayCommand DeleteCommand => new RelayCommand(execute => DeleteItem(SelectedItem), canExecute => SelectedItem != null);
        public RelayCommand SaveCommand => new RelayCommand(execute => Save(SelectedItem), canExecute => CanSave());
        public MainWindowViewModel()
        {
            Items = new ObservableCollection<Item>();            
        }
        private Item selectedItem; 
        public Item SelectedItem
        {
            get { return selectedItem; }
            set 
            { 
                selectedItem = value;
                OnPropertyChanged();
            }
        }
        
        private void AddItem()
        {
            Items.Add(new Item
            {
                Name = "Laptop Computer",
                SerialNumber = "00-010-23",
                Quantity = 10
            });

            Items.Add(new Item
            {
                Name = "Mouse",
                SerialNumber = "00-010-111",
                Quantity = 20
            });
            Items.Add(new Item
            {
                Name = "Mouse Pad",
                SerialNumber = "01-02-23",
                Quantity = 15
            });
            Items.Add(new Item
            {
                Name = "Keyboard",
                SerialNumber = "00-0100-230",
                Quantity = 80
            });
        }
        private void DeleteItem(Item item)
        {
            Items.Remove(item);
        }
        private void Save()
        {
            // Save operation db, file, ...
        }

        private bool CanSave()
        {
            return true;
        }
    }
}
