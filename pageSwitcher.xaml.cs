using System;
using System.Windows;
using System.Windows.Controls;
using pdfReader.view;

//using org.pdfclown.documents.Document;
//using org.pdfclown.files.File;

namespace pdfReader {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class PageSwitcher : Window {
        public PageSwitcher() {
            this.InitializeComponent();
            Switcher.pageSwitcher = this;
            Switcher.Switch(new LoginView());
        }

        public void Navigate(UserControl nextPage)
        {
            this.Content = nextPage;
        }

        public void Navigate(UserControl nextPage, object state)
        {
            this.Content = nextPage;
            ISwitchable s = nextPage as ISwitchable;

            if (s != null)
                s.UtilizeState(state);
            else
                throw new ArgumentException("NextPage is not ISwitchable! "
                    + nextPage.Name.ToString());
        }
    }
}
