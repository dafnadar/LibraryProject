using BookLib;
using GalaSoft.MvvmLight;
using Logic;

namespace MyLibrary.ViewModel
{
    public class EditJournalViewModel : ViewModelBase
    {
        private readonly ItemCollection itemCollection = ItemCollection.Instance;

        //private AbstractItem itemToEdit;
        //public AbstractItem ItemToEdit { get => itemToEdit; set => itemToEdit = value; }

        //public string Title { get; set => Set(ref Title, value); }

        public string Title { get; set; }

        //public RelayCommand SaveCommand { get; set; }
        public EditJournalViewModel()
        {
            //SaveCommand = new RelayCommand(CheckEdit);
            MessengerInstance.Register<AbstractItem>(this, SetItemToEdit);
        }

        private void SetItemToEdit(AbstractItem obj)
        {
        }

        //private void CheckEdit()
        //{

        //    //if (itemCollection.IsJournalFieldsOk(ItemToEdit)) MessageBox.Show("Changes Saved");
        //}

    }
}
