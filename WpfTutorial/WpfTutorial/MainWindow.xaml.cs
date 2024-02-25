using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;

namespace WpfTutorial
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        public MainWindow()
        {
            DataContext = this;
            InitializeComponent();
        }

        private string boundText;

        public event PropertyChangedEventHandler? PropertyChanged;

        public string BoundText
        {
            get { return boundText; }
            set 
            {
                boundText = value;
                this.OnPropertyChanged();
            }
        }

        private void btnSet_Click(System.Object sender, RoutedEventArgs e)
        {
            // MessageBox.Show("Cound not open file:", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            MessageBoxResult result = MessageBox.Show("Do you agree ?", "Agreement", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if(result == MessageBoxResult.Yes)
            {
                tbResult.Text = "Agreed";
            }
            else
            {
                tbResult.Text = "Not Agreed";
            }
        }

        private void OnPropertyChanged([CallerMemberName]string propertyName = null)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
