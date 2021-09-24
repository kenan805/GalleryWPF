using GalleryWPF.Models;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
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

namespace GalleryWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Photo> Images { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
            Images = new ObservableCollection<Photo>()
            {
                new Photo
                {
                     ImagePath=@"Images\image1.jpg"
                },
                new Photo
                {
                     ImagePath=@"Images\Baku.jpg"
                },
                new Photo
                {
                     ImagePath=@"Images\qizqalasi.jpg"
                },
                new Photo
                {
                     ImagePath=@"Images\Quba.jpg"
                },
                new Photo
                {
                     ImagePath=@"Images\Qusar.jpg"
                },
                new Photo
                {
                     ImagePath=@"Images\selale.jpg"
                },
                new Photo
                {
                     ImagePath=@"Images\Sumqayit.jpg"
                },
                new Photo
                {
                     ImagePath=@"Images\Susa.jpg"
                }
            };
        }

        private void MenuItem_Exit_Click(object sender, RoutedEventArgs e) => Close();

        private void MenuItem_AddFile_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Select a picture";
            openFileDialog.Filter = "PNG Files (*.png)|*.png|JPEG Files (*.jpeg)|*.jpeg|JPG Files (*.jpg)|*.jpg";
            if (openFileDialog.ShowDialog() == true)
            {
                Photo newImage = new Photo()
                {
                    ImagePath = openFileDialog.FileName
                };
                Images.Add(newImage);
            }
        }

        private void MenuItem_SmallIcons_Click(object sender, RoutedEventArgs e) => Resources["imgSize"] = 50.0;

        private void MenuItem_MediumIcons_Click(object sender, RoutedEventArgs e) => Resources["imgSize"] = 150.0;

        private void MenuItem_LargeIcons_Click(object sender, RoutedEventArgs e) => Resources["imgSize"] = 250.0;

        private void ListViewImages_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var image = listViewImages.SelectedItem as Photo;
            var selectedIndex = listViewImages.SelectedIndex;
            var lastIndex = listViewImages.Items.Count - 1;
            var imgPage = new ImagePage();
            imgPage.imgCurrentIndex = selectedIndex;
            imgPage.imgLastIndex = lastIndex;
            imgPage.images = Images;
            imgPage.fullImage.Source = new BitmapImage(new Uri(image.ImagePath, UriKind.RelativeOrAbsolute));
            ImageFrame.NavigationService.Navigate(imgPage);
        }

        private void ListViewImages_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap))
                e.Effects = DragDropEffects.Copy;
            else
                e.Effects = DragDropEffects.None;
        }

        private void ListViewImages_Drop(object sender, DragEventArgs e)
        {

            var image = new Photo();
            string path = "";
            string[] filenames = e.Data.GetData(DataFormats.FileDrop) as string[];
            if (filenames != null)
            {
                foreach (var name in filenames)
                {
                    try
                    {
                        path = name;
                        image.ImagePath = path;
                        Images.Add(image);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }

            }


        }
    }
}
