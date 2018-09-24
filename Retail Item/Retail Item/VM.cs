using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Retail_Item
{
    class VM : INotifyPropertyChanged
    {
        //Constants to be used
        #region Constants
        const int INITIAL_ITEM_INDEX = 0;
        const int NUMBER_OF_JACKET = 12;
        const int NUMBER_OF_JEAN = 40;
        const int NUMBER_OF_SHIRT = 20;
        const int NUMBER_OF_ITEMS = 3;
        const decimal PRICE_OF_JACKET = 59.9m;
        const decimal PRICE_OF_JEAN = 34.95m;
        const decimal PRICE_OF_SHIRT = 24.95m;
        const int JACKET_INDEX = 0;
        const int JEAN_INDEX = 1;
        const int SHIRT_INDEX = 2;
        const string DESCRIPTION_JACKET = "Jacket";
        const string DESCRIPTION_JEAN = "Jeans";
        const string DESCRIPTION_SHIRT = "Shirt";
        #endregion

        #region Properties
        //List to display the data of class Retailitem
        List<RetailItem> retailItems = new List<RetailItem>();
        public List<RetailItem> RetailItems
        {
            get { return retailItems; }
            set { retailItems = value; notifyChanged(); }
        }
        #endregion

        #region Method
        public VM()
        {
            //intializing the data using an array
            RetailItem[] item = new RetailItem[NUMBER_OF_ITEMS];
            item[JACKET_INDEX] = new RetailItem(DESCRIPTION_JACKET, NUMBER_OF_JACKET, PRICE_OF_JACKET);
            item[JEAN_INDEX] = new RetailItem(DESCRIPTION_JEAN, NUMBER_OF_JEAN, PRICE_OF_JEAN);
            item[SHIRT_INDEX] = new RetailItem(DESCRIPTION_SHIRT, NUMBER_OF_SHIRT, PRICE_OF_SHIRT);
            // dispaly the data into list using for loop
            for (int itemIndex = INITIAL_ITEM_INDEX; itemIndex < item.Length; itemIndex++)
            {
                retailItems.Add(item[itemIndex]);
            }
        }
        #endregion

        #region PropertyChange
        public event PropertyChangedEventHandler PropertyChanged;
        private void notifyChanged([CallerMemberName] string name = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
        #endregion
    }
}
