using System;
using System.Windows;
using System.Windows.Controls;

namespace Retail_Item
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // making the instance of vm and retaildetails
        VM vm = new VM();
        RetailDetails retailDetails = null;
        public MainWindow()
        {
            InitializeComponent();
            DataContext = vm;
        }
        // passing the value by parameters to another window
        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (retailDetails == null)
            {
                RetailItem items = ((ListBox)sender).SelectedItem as RetailItem;
                retailDetails = new RetailDetails(items);
                retailDetails.Closed += Retail_CLOSED;
                retailDetails.Show();
            }
        }
        private void Retail_CLOSED(object sender, EventArgs e)
        {
            retailDetails = null;
        }
    }
}

