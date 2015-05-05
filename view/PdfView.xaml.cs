using System;
using System.Windows;
using System.Windows.Controls;

using org.pdfclown.files;
using org.pdfclown.documents;
using org.pdfclown.tools;
using System.IO;
using System.Windows.Media.Imaging;
using System.Drawing;
using Microsoft.Win32;

namespace pdfReader.view {
    /// <summary>
    /// Interaction logic for PdfView.xaml
    /// </summary>
    public partial class PdfView : UserControl {
        public RenderingPdf renderingImage;
        System.Drawing.Bitmap bmp;
 
        public PdfView() {
            this.InitializeComponent();
        }

        private void openFileDialog_Click(object sender, RoutedEventArgs e) {
            OpenFileDialog op = new OpenFileDialog();
            op.Title = "Select a pdf document";
            op.DefaultExt = ".pdf"; // Default file extension
            op.Filter = "Text documents (.pdf)|*.pdf";
            
            if (op.ShowDialog() == true) {
                // Open document 
                //this.createPdfInstance(fileWindow.FileName);
                renderingImage = new RenderingPdf(op.FileName);

                imageView.Source = renderingImage.createImage();
            }
        }

        private void changeUser_Click(object sender, RoutedEventArgs e) {
            Switcher.Switch(new LoginView());
        }

        private void Button_Click(object sender, RoutedEventArgs e) {
        }
    }
}
