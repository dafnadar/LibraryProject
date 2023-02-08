using System;

namespace BookLib
{
    public class Book : AbstractItem
    {
        public string ISBN { get; set; }
        public string Author { get; set; }
        public string Publishing { get; set; }
        public int PublishYear { get; set; }
        public BookGenre Genre { get; set; }
        public Book(string title, string author = "") : base(title)
        {
            ISBN = Guid.NewGuid().ToString();
            Author = author;
        }

        public override string GetItemProp()
        {
            return $"ISBN: {ISBN} Author: {Author} Publishing: {Publishing} PublishYear: {PublishYear}" +
                $" Genre: {Genre} {base.GetItemProp()}";
        }
    }

}
