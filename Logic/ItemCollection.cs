using BookLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace Logic
{
    public class ItemCollection
    {
        public Action<AbstractItem> AddItemAction { get; set; } //get address of AddItemAct 

        private readonly List<AbstractItem> items;

        //public string ShowItemDetails(AbstractItem item)
        //{
        //   return item.GetItemProp();
        //}

        //public string GetItem(AbstractItem item)
        //{
        //    return items.Get
        //}


        public void AddItem(AbstractItem item)
        {
            if (CheckFields(item))
            {
                items.Add(item);
                AddItemAction?.Invoke(item);
                MessageBox.Show($" {item.GetType().Name} Added");
                //ClearFields(item.GetType());
            }
        }

        private bool CheckFields(AbstractItem item)
        {
            return true;
        }

        private void ClearFields(Type type)
        {
            if (type == typeof(Book))
            {

            }
            else
            {

            }
        }



        private void SetData()
        {
            items.Add(new Book("Vegan Cooking") { Author = "Dafna Dar", Price = 50, PublishYear = 2010, Genre = BookGenre.Cooking });
            items.Add(new Book("Pinokyo") { Author = "Udi Dar", Price = 20, Genre = BookGenre.Comedy });
            items.Add(new Journal("For Her") { Price = 10, PrintDate = new DateTime(2020, 10, 30) });
            items.Add(new Journal("For Her") { Price = 10, Subject = JournalSubject.Business });
            items.Add(new Journal("For Him") { Price = 12 });
            items.Add(new Journal("For Him") { Price = 12, Subject = JournalSubject.Music | JournalSubject.Children });
            items.Add(new Book("Aladdin") { Price = 20, PublishYear = 1990 });
        }

        public void RemoveItem(AbstractItem item)
        {
            items.Remove(item);
            MessageBox.Show("Item Deleted");
        }

        public bool IsJournalFieldsOk(Journal item)
        {
            if (string.IsNullOrEmpty(item.Title)
                || item.Sheet < 0 || item.Copies < 0
                || item.Price < 0) return false;
            else
            {
                EditJournal(item);
                return true;
            }            //return CheckJournalFields((Journal)item);
            //else return CheckBookFields((Book)item);
        }

        private void EditJournal(Journal item)
        {
            throw new NotImplementedException();
        }




        //public List<AbstractItem> GetItems() => Items;

        public IEnumerable<AbstractItem> GetItems() => items;
        public IEnumerable<AbstractItem> GetItemsByType(IEnumerable<AbstractItem> items, Types type) =>
            items.Where(i => i.GetType().Name.ToString().Equals(type.ToString()));
        public IEnumerable<AbstractItem> GetItemsByTitle(IEnumerable<AbstractItem> items, string title) =>
            items.Where(i => i.Title.ToLower().Contains(title));
        public IEnumerable<AbstractItem> GetItemsByAuthor(IEnumerable<AbstractItem> items, string author) =>
            items.OfType<Book>().Where(i => i.Author.ToLower().Contains(author));
        public IEnumerable<AbstractItem> GetItemsByYear(IEnumerable<AbstractItem> items, int year) =>
            items.OfType<Book>().Where(i => i.PublishYear >= year);
        public IEnumerable<AbstractItem> GetItemsFromPrice(IEnumerable<AbstractItem> items, int price) =>
            items.Where(i => i.Price >= price);
        public IEnumerable<AbstractItem> GetItemsToPrice(IEnumerable<AbstractItem> items, int price) =>
            items.Where(i => i.Price <= price);
        public IEnumerable<AbstractItem> GetItemByISBN(IEnumerable<AbstractItem> items, string isbn) =>
            items.OfType<Book>().Where(i => i.ISBN.Equals(isbn));
        public IEnumerable<AbstractItem> GetFilteredList(Types type, string title, string author, int year, int fPrice, int tPrice, string isbn)
        {            
            if (tPrice == 0) tPrice = int.MaxValue;
            if (type.ToString() != "Journal" && isbn != null) return GetItemByISBN(items, isbn);

            var byType = GetItems();
            if (type.ToString() != "All")
                byType = GetItemsByType(items, type);
            var byTitle = GetItemsByTitle(byType, title);
            var fromPrice = GetItemsFromPrice(byTitle, fPrice);
            var toPrice = GetItemsToPrice(fromPrice, tPrice);
            var byAuthor = GetItemsByAuthor(toPrice, author);
            var byYear = GetItemsByYear(byAuthor, year);

            if (type.ToString() == "Journal" || (author == "" && year == 0)) return toPrice;
            else return byYear;
        }

        #region Singleton
        private static ItemCollection instance;
        public static ItemCollection Instance => instance ?? (instance = new ItemCollection());

        private ItemCollection()
        {
            items = new List<AbstractItem>();
            SetData();
        }

        #endregion        
    }
}
