using org.pdfclown.documents;
using org.pdfclown.documents.contents.entities;
using org.pdfclown.files;
using org.pdfclown.tools;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Media.Imaging;

namespace pdfReader {
    public class RenderingPdf {
        private string filePath;

        public RenderingPdf(String filePath) {
            this.filePath = filePath;
        }

        public System.Windows.Media.Imaging.BitmapImage createImage() {
            string fileName = filePath;
            using (var file = new org.pdfclown.files.File(fileName)) {
                Document document = file.Document;
                Pages pages = document.Pages;

                Page page = pages[0];
                SizeF imageSize = page.Size;
                Renderer renderer = new Renderer();
                System.Drawing.Image image = renderer.Render(page, imageSize);

                // Winforms Image we want to get the WPF Image from
                var bitmap = new System.Windows.Media.Imaging.BitmapImage();
                bitmap.BeginInit();
                MemoryStream memoryStream = new MemoryStream();
                // Save to a memory stream
                image.Save(memoryStream, ImageFormat.Bmp);
                // Rewind the stream
                memoryStream.Seek(0, System.IO.SeekOrigin.Begin);
                bitmap.StreamSource = memoryStream;
                bitmap.EndInit();

                return bitmap;
            }
        }
    }
}