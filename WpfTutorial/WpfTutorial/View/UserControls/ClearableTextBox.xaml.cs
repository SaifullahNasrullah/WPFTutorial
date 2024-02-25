using System;
using System.Windows;
using System.Windows.Controls;

namespace WpfTutorial.View.UserControls
{
    /// <summary>
    /// Interaction logic for ClearableTextBox.xaml
    /// </summary>
    public partial class ClearableTextBox : UserControl
    {
        public ClearableTextBox()
        {
            InitializeComponent();
        }

        private string placehoder;

        public string Placehoder
        {
            get { return placehoder; }
            set 
            { 
                placehoder = value;

                // do not this!!
                tbPlaceholder.Text = placehoder;

                // use OnPropertyChanged()
            }
        }

        private void btnClear_Click(Object sender, RoutedEventArgs e)
        {
            txtInput.Clear();
            txtInput.Focus();
        }

        private void txtInput_TextChanged(Object sender, TextChangedEventArgs e)
        {
            if(string.IsNullOrEmpty(txtInput.Text))
                tbPlaceholder.Visibility= Visibility.Visible;
            else
                tbPlaceholder.Visibility= Visibility.Hidden;
        }
    }
}
