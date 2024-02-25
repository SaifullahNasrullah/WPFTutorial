using System.Windows;
using WPFTutorial12.ViewModel;

namespace WPFTutorial12
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainWindowViewModel vm = new MainWindowViewModel();
            DataContext= vm;
        }
    }
}
