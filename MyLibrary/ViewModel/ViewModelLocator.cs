/*
  In App.xaml:
  <Application.Resources>
      <vm:ViewModelLocator xmlns:vm="clr-namespace:MyLibrary"
                           x:Key="Locator" />
  </Application.Resources>
  
  In the View:
  DataContext="{Binding Source={StaticResource Locator}, Path=ViewModelName}"

  You can also use Blend to do all this with the tool's support.
  See http://www.galasoft.ch/mvvm
*/

using CommonServiceLocator;
using GalaSoft.MvvmLight.Ioc;

namespace MyLibrary.ViewModel
{
    public class ViewModelLocator
    {
        public ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);

            SimpleIoc.Default.Register<MainViewModel>();
            SimpleIoc.Default.Register<MyMenuViewModel>();
            SimpleIoc.Default.Register<SearchViewModel>();
            SimpleIoc.Default.Register<AddBookViewModel>();
            SimpleIoc.Default.Register<ShowListViewModel>();
            SimpleIoc.Default.Register<AddItemViewModel>();
            SimpleIoc.Default.Register<AddJournalViewModel>();
            SimpleIoc.Default.Register<ShowDetailsViewModel>();
            SimpleIoc.Default.Register<EditJournalViewModel>();
        }

        public MainViewModel Main => ServiceLocator.Current.GetInstance<MainViewModel>();
        public MyMenuViewModel MyMenu => ServiceLocator.Current.GetInstance<MyMenuViewModel>();
        public SearchViewModel Search => ServiceLocator.Current.GetInstance<SearchViewModel>();
        public AddBookViewModel AddBook => ServiceLocator.Current.GetInstance<AddBookViewModel>();
        public ShowListViewModel ShowList => ServiceLocator.Current.GetInstance<ShowListViewModel>();
        public AddItemViewModel AddItem => ServiceLocator.Current.GetInstance<AddItemViewModel>();
        public AddJournalViewModel AddJournal => ServiceLocator.Current.GetInstance<AddJournalViewModel>();
        public ShowDetailsViewModel ShowDetails => ServiceLocator.Current.GetInstance<ShowDetailsViewModel>();
        public EditJournalViewModel EditJournal => ServiceLocator.Current.GetInstance<EditJournalViewModel>();
    }
}