using GalleryWPF.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading;
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
    /// Interaction logic for ImagePage.xaml
    /// </summary>
    public partial class ImagePage : Page
    {
        public int imgCurrentIndex { get; set; }
        public int imgLastIndex { get; set; }
        public ObservableCollection<Photo> images { get; set; }

        System.Windows.Threading.DispatcherTimer dispatcherTimer = new System.Windows.Threading.DispatcherTimer();
        public ImagePage()
        {
            InitializeComponent();
        }

        private void PlayImages()
        {
            dispatcherTimer.Start();
            dispatcherTimer.Interval = new TimeSpan(0,0,0,2);
            if (imgCurrentIndex != imgLastIndex)
            {
                fullImage.Source = new BitmapImage(new Uri(images[imgCurrentIndex + 1].ImagePath, UriKind.RelativeOrAbsolute));
                imgCurrentIndex += 1;
            }
            else
            {
                imgCurrentIndex = 0;
                fullImage.Source = new BitmapImage(new Uri(images[imgCurrentIndex].ImagePath, UriKind.RelativeOrAbsolute));
            }

        }
        private void PlayImages_Tick(object sender, EventArgs e)
        {
            PlayImages();
        }

        private void Button_Back_Click(object sender, RoutedEventArgs e) => Visibility = Visibility.Hidden;

        private void Button_Next_Click(object sender, RoutedEventArgs e)
        {
            if (imgCurrentIndex != imgLastIndex)
            {
                fullImage.Source = new BitmapImage(new Uri(images[imgCurrentIndex + 1].ImagePath, UriKind.RelativeOrAbsolute));
                imgCurrentIndex += 1;
            }
            else
            {
                imgCurrentIndex = 0;
                fullImage.Source = new BitmapImage(new Uri(images[imgCurrentIndex].ImagePath, UriKind.RelativeOrAbsolute));
            }

        }

        private void Button_Previous_Click(object sender, RoutedEventArgs e)
        {
            if (imgCurrentIndex != 0)
            {
                fullImage.Source = new BitmapImage(new Uri(images[imgCurrentIndex - 1].ImagePath, UriKind.RelativeOrAbsolute));
                imgCurrentIndex -= 1;
            }
            else
            {
                imgCurrentIndex = imgLastIndex;
                fullImage.Source = new BitmapImage(new Uri(images[imgCurrentIndex].ImagePath, UriKind.RelativeOrAbsolute));
            }
        }

        private void Button_PlayImage_Click(object sender, RoutedEventArgs e)
        {
            PlayImages();
            dispatcherTimer.Tick += new EventHandler(PlayImages_Tick);
        }

        private void Button_ImagePause_Click(object sender, RoutedEventArgs e)
        {
            dispatcherTimer.Stop();
        }
    }
}
