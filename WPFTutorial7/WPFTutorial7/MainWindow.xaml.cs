using System;
using System.Windows;

namespace WPFTutorial7
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnDetails_Click(Object sender, RoutedEventArgs e)
        {
            expanderDetails.IsExpanded = !expanderDetails.IsExpanded;
        }
    }
}
