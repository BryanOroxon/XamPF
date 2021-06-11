using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamPF.ViewModels;

namespace XamPF.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AudioBookPage : ContentPage
    {
        public AudioBookPage()
        {
            InitializeComponent();

            BindingContext = new AudioBookViewModel();
        }

        private async void CollectionView_SelectedItem(object sender, SelectionChangedEventArgs e)
        {
            var selectedItem = e.CurrentSelection.FirstOrDefault();

            if (selectedItem != null)
            {

                carouselView_AudioBookRead.ScrollTo
                 (
                    item: selectedItem,
                    position: ScrollToPosition.Start,
                    animate: true
                 );

                await Task.Delay(350);
                await Navigation.PushModalAsync(new AudioBookDetailPage(selectedItem as BooksViewModel), true);
            }

            carouselView_AudioBookRead.SelectedItem = null;
        }
    }
}