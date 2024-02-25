using FileDialog = Microsoft.Win32;
using System;
using System.Windows;
using WinForms = System.Windows.Forms;
namespace WPFTutorial2
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

        private void btnFire_Click(Object sender, RoutedEventArgs e)
        {
            FileDialog.OpenFileDialog fileDialog = new FileDialog.OpenFileDialog();
            fileDialog.Filter = "C# Source Files | *.dcm";
            fileDialog.Multiselect = true;
            bool? success = fileDialog.ShowDialog();
            if(success == true)
            {
                string [] paths = fileDialog.FileNames;
                string[] names = fileDialog.SafeFileNames;
            }
            else
            {
                // do something
            }
        }

        private void btnFireFile_Click(Object sender, RoutedEventArgs e)
        {
            WinForms.FolderBrowserDialog folderBrowser = new WinForms.FolderBrowserDialog();
            folderBrowser.InitialDirectory = "C:\\Users\\snasrullah\\Desktop\\Exersize\\WPFTutorial2";
            var result = folderBrowser.ShowDialog();
            if(result == WinForms.DialogResult.OK)
            {
                string folder = folderBrowser.SelectedPath;
            }
            else
            {
                // do something 
            }
        }
    }
}
