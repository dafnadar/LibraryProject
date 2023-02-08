namespace BookLib
{
    public abstract class AbstractItem
    {
        private static int id;
        public int Id { get; set; }
        public string Title { get; set; }
        public double Price { get; set; }
        public int Copies { get; set; }  

        public AbstractItem(string title)
        {
            Id = ++id;
            Title = title;
        }

        public virtual string GetItemProp()
        {
            return $"Id: {Id}  Title: {Title}  Price: {Price}  Copies: {Copies}";
        }
    }

}
