using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MyLibrary.View
{
    public partial class ShowDetailsView : UserControl
    {
        public ShowDetailsView()
        {
            InitializeComponent();
        }

        private void OpenEditItemWindow_Click(object sender, RoutedEventArgs e)
        {
            var editWin = new EditJournalView();
            editWin.Show();
        }
    }
}
