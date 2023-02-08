using BookLib;
using Logic;
using System.Collections.ObjectModel;

namespace MyLibrary.ViewModel
{
    public class ShowListViewModel
    {
        ItemCollection itemCollection = ItemCollection.Instance;
        public ObservableCollection<AbstractItem> AllItems { get; set; }

        public ShowListViewModel()
        {
            AllItems = new ObservableCollection<AbstractItem>(itemCollection.GetItems());   // insert instance to O.C. Items       
            itemCollection.AddItemAction += AddItem;
        }

        private void AddItem(AbstractItem item) => AllItems.Add(item);
    }
}
