using System;

namespace BookLib
{
    public class Journal : AbstractItem
    {       
        public int Sheet { get; set; }
        public DateTime PrintDate { get; set; }
        public JournalSubject Subject { get; set; }

        public Journal(string title) : base(title)
        {
            
        }

        public override string GetItemProp()
        {
            return $"Sheet: {Sheet} PrintDate: {PrintDate} Subject: {Subject} {base.GetItemProp()}";
        }
    }    

}
