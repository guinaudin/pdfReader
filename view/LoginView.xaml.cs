using pdfReader.view;
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

namespace pdfReader {
    /// <summary>
    /// Interaction logic for LoginView.xaml
    /// </summary>
    public partial class LoginView : UserControl, ISwitchable {
        public LoginView() {
            this.InitializeComponent();
        }

        private void loginButton_Click(object sender, System.Windows.RoutedEventArgs e) {
            if (usernameTextBox.Text.Equals("guinaudin") && passwordBox.Password.Equals("guinaudin")) {
                Switcher.Switch(new PdfView());
            }
        }

        #region ISwitchable Members

        public void UtilizeState(object state) {
            throw new NotImplementedException();
        }

        #endregion
    }
}

