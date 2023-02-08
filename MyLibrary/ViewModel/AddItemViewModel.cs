using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MyLibrary.ViewModel
{
    public class AddItemViewModel : ViewModelBase
    {
        private Visibility visibilityBook = Visibility.Hidden;
        private Visibility visibilityJournal = Visibility.Hidden;

        public Visibility VisibilityBook { get => visibilityBook; set => Set(ref visibilityBook, value); }
        public Visibility VisibilityJournal { get => visibilityJournal; set => Set(ref visibilityJournal, value); }



        public RelayCommand ShowAddBook_Command { get; set; }
        public RelayCommand ShowAddJournal_Command { get; set; }
        public AddItemViewModel()
        {
            VisibilityJournal = Visibility.Hidden;
            VisibilityBook = Visibility.Visible;
            ShowAddBook_Command = new RelayCommand(ShowAddBookView);
            ShowAddJournal_Command = new RelayCommand(ShowAddJournalView);            
        }

        private void ShowAddJournalView()
        {
            VisibilityBook = Visibility.Hidden;
            VisibilityJournal = Visibility.Visible;
        }

        private void ShowAddBookView()
        {            
            VisibilityBook = Visibility.Visible;
            VisibilityJournal = Visibility.Collapsed;
        }
    }
}
