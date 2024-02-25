using System.Windows;

namespace WPFTutorial9.View
{
    /// <summary>
    /// Interaction logic for ModalWindow.xaml
    /// </summary>
    public partial class ModalWindow : Window
    {
        public bool Success { get; set; }
        public string Input { get; set; }
        public ModalWindow(Window parentWindow)
        {
            Owner= parentWindow;
            InitializeComponent();
        }

        private void btnOk_Click(System.Object sender, RoutedEventArgs e)
        {
            Success= true;
            Input = txtInput.Text;
            Close();
        }

        private void btnConcel_Click(System.Object sender, RoutedEventArgs e)
        {
            Success= false;
            Close();
        }

        private void txtInput_TextChanged(System.Object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            if(!string.IsNullOrEmpty(txtInput.Text))
                btnOk.IsEnabled = true;
            else btnOk.IsEnabled = false;
        }
    }
}
