using BookLib;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using Logic;
using System;

namespace MyLibrary.ViewModel
{
    public class ShowDetailsViewModel : ViewModelBase
    {
        private readonly ItemCollection itemCollection = ItemCollection.Instance;

        private AbstractItem selectedItem;
        //private string itemDetalis;

        public AbstractItem SelectedItem { get => selectedItem; set => Set(ref selectedItem, value); }

        //public string ItemDetalis { get => itemDetalis = itemCollection.ShowItemDetails(SelectedItem); set => itemDetalis = itemCollection.ShowItemDetails(SelectedItem); }

        public RelayCommand DeleteCommand { get; set; }

        public ShowDetailsViewModel()
        {
            MessengerInstance.Register<AbstractItem>(this, SetSelecteditem);
            DeleteCommand = new RelayCommand(DeleteItem);
        }

        private void DeleteItem() => itemCollection.RemoveItem(SelectedItem);
        private void SetSelecteditem(AbstractItem obj) => SelectedItem = obj;
    }
}
