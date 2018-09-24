using System.Windows;

namespace Retail_Item
{
    /// <summary>
    /// Interaction logic for RetailDetails.xaml
    /// </summary>
    public partial class RetailDetails : Window
    {
        public RetailItem RetailItem { get; set; }
        public RetailDetails()
        {
            InitializeComponent();
        }
        // constructor of the class having the retailitem as parameter
        public RetailDetails(RetailItem retailItem)
        {
            InitializeComponent();
            RetailItem = retailItem;
        }
        // assigning the data using parameter method
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            TheDescription.Content = "Description: " + RetailItem.Description;
            TheUnit.Content = "Unit On Hand: " + RetailItem.UnitOnHand;
            ThePrice.Content = "Price: $" + RetailItem.Price;
        }
    }
}
