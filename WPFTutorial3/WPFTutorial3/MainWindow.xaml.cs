using System;
using System.Collections;
using System.Reflection;
using System.Windows;

namespace WPFTutorial3
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

        private void btnAdd_Click(Object sender, RoutedEventArgs e)
        {
            lvEnteries.Items.Add(txtEntery.Text);
            txtEntery.Clear();
        }

        private void btnClear_Click(Object sender, RoutedEventArgs e)
        {
            lvEnteries.Items.Clear();
        }

        private void btnDelete_Click(Object sender, RoutedEventArgs e)
        {
            // SelectedIndex : returns the first selected index
            // SelectedItem  : returns the item
            // SelectedItems : returns the collection of items

            // int index = lvEnteries.SelectedIndex;
            // lvEnteries.Items.RemoveAt(index); // removes from the given index

            /*var item = lvEnteries.SelectedItem;
            var result = MessageBox.Show($"Are you sure to delete {(string)item}", "Sure", MessageBoxButton.YesNo);
            if(result == MessageBoxResult.Yes)
            {
                lvEnteries.Items.Remove(item);
            }*/

            var items = lvEnteries.SelectedItems;
            var result = MessageBox.Show($"Are you sure to delete {items.Count}", "Sure", MessageBoxButton.YesNo);
            if (result == MessageBoxResult.Yes)
            {
                var itemList = new ArrayList(items);
                foreach(var item in itemList)
                    lvEnteries.Items.Remove(item);
            }
        }
    }
}
