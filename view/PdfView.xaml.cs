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

namespace pdfReader.view {
    /// <summary>
    /// Interaction logic for PdfView.xaml
    /// </summary>
    public partial class PdfView : UserControl {
        public PdfView() {
            this.InitializeComponent();
        }

        private void openFileDialog_Click(object sender, RoutedEventArgs e) {
            string filename = "";

            // Configure open file dialog box
            Microsoft.Win32.OpenFileDialog fileWindow = new Microsoft.Win32.OpenFileDialog();
            fileWindow.FileName = "Document"; // Default file name
            fileWindow.DefaultExt = ".pdf"; // Default file extension
            fileWindow.Filter = "Text documents (.pdf)|*.pdf"; // Filter files by extension 

            // Show open file dialog box
            Nullable<bool> result = fileWindow.ShowDialog();

            // Process open file dialog box results 
            if (result == true)
            {
                // Open document 
                filename = fileWindow.FileName;
            }
        }

        private void changeUser_Click(object sender, RoutedEventArgs e) {
            Switcher.Switch(new LoginView());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
