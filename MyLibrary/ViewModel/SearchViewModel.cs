using BookLib;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using Logic;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;

namespace MyLibrary.ViewModel
{
    public class SearchViewModel : ViewModelBase
    {
        private readonly ItemCollection itemCollection = ItemCollection.Instance;


        private ObservableCollection<AbstractItem> items;
        public ObservableCollection<AbstractItem> Items { get => items; set => Set(ref items, value); }


        private AbstractItem selectedItem;
        public AbstractItem SelectedItem
        {
            get => selectedItem;
            set
            {
                selectedItem = value;
                MessengerInstance.Send(SelectedItem);
            }
        }

        public List<Types> Types { get; set; }
        public Types Type { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }
        public int FromPrice { get; set; }
        public int ToPrice { get; set; }
        public string ISBN { get; set; }

        public RelayCommand SearchCommand { get; set; }

        public SearchViewModel()
        {            
            Title = "";
            Author = "";
            Types = Enum.GetValues(typeof(Types)).Cast<Types>().ToList();
            SearchCommand = new RelayCommand(SearchItems);
        }

        private void SearchItems()
        {

                Items = new ObservableCollection<AbstractItem>(itemCollection.GetFilteredList(Type, Title.ToLower(), Author.ToLower(), Year, FromPrice, ToPrice, ISBN));

        }
            
    }
}
