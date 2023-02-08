using BookLib;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MyLibrary.ViewModel
{
    public class AddJournalViewModel : ViewModelBase
    {
        ItemCollection itemCollection = ItemCollection.Instance;
        //private Journal newJournal;

        //public Journal NewJournal
        //{
        //    get => newJournal;
        //    set
        //    {
        //        Set(ref newJournal, value);                
        //    }
        //}

        public List<JournalSubject> Subjects { get; set; }


        public string Title { get; set; }
        public int Sheet { get; set; }
        public int Price { get; set; }
        public JournalSubject Subject { get; set; }
        public int Copies { get; set; }
        public DateTime Date { get; set; }

        //public RelayCommand AddSubject_Command { get; set; }

        public RelayCommand AddJournalCommand { get; set; }

        public AddJournalViewModel()
        {
            AddJournalCommand = new RelayCommand(AddJournal);
            //AddSubject_Command = new RelayCommand(AddSubject);
            Subjects = Enum.GetValues(typeof(JournalSubject)).Cast<JournalSubject>().ToList();
        }

        //private void AddSubject()
        //{
        //    if (!NewJournal.Subject.HasFlag(JournalSubject))
        //    {
        //        NewJournal.Subject |= Subject;
        //    }

        //}

        private void AddJournal()
        {
            if (!string.IsNullOrEmpty(Title))
            {
                Journal jur = new Journal(Title)
                {
                    Sheet = Sheet,
                    Price = Price,
                    Subject = Subject,
                    Copies = Copies,
                    PrintDate = Date
                };
                itemCollection.AddItem(jur);
            }
            else MessageBox.Show("Check Fields");
        }
    }
}
