using System.Collections.ObjectModel;
using System.Windows;

namespace WPFTutorial4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            DataContext = this;
            enteries = new ObservableCollection<string>();

            InitializeComponent();
        }

        private ObservableCollection<string> enteries;

        public ObservableCollection<string> Enteries
        {
            get { return enteries; }
            set 
            { 
                enteries = value; 
            }
        }

        private void btnAdd_Click(System.Object sender, RoutedEventArgs e)
        {
            Enteries.Add(txtEntery.Text);
        }

        private void btnDelete_Click(System.Object sender, RoutedEventArgs e)
        {
            string selectedItem = (string)lvEnteries.SelectedItem;
            Enteries.Remove(selectedItem);
        }

        private void btnClear_Click(System.Object sender, RoutedEventArgs e)
        {
            Enteries.Clear();
        }
    }
}
