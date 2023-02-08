using BookLib;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MyLibrary.ViewModel
{
    public class AddBookViewModel : ViewModelBase
    {
        readonly ItemCollection itemCollection = ItemCollection.Instance;
        public List<BookGenre> Genres { get; set; }
        public string Title { get; set; }
        public int Price { get; set; }
        public string Author { get; set; }
        public string Publishing { get; set; }
        public int Copies { get; set; }
        public BookGenre Genre { get; set; }
        public int Year { get; set; }

        public RelayCommand AddBookCommand { get; set; }
        public AddBookViewModel()
        {
            AddBookCommand = new RelayCommand(AddBook);
            Genres = Enum.GetValues(typeof(BookGenre)).Cast<BookGenre>().ToList();
        }

        private bool CheckNewBook()
        {
            DateTime now = DateTime.Now;
            if (string.IsNullOrEmpty(Title) ||
                Year < 0 ||
                Year > now.Year) return false;
            else return true;
        }

        private void AddBook()
        {
            if (CheckNewBook())
            {
                Book book = new Book(Title)
                {
                    Price = Price,
                    Author = Author,
                    Publishing = Publishing,
                    Copies = Copies,
                    Genre = Genre,
                    PublishYear = Year
                };
                itemCollection.AddItem(book);                
            }
            else
                MessageBox.Show("Check Fields");
        }
    }
}
