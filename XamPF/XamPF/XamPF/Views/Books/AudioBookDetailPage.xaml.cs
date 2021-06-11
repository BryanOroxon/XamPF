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
    public partial class AudioBookDetailPage : ContentPage
    {
        public AudioBookDetailPage(BooksViewModel booksViewModel)
        {
            InitializeComponent();

            BindingContext = new AudioBookDetailViewModel
                              (navigation: Navigation,
                              selectedBooksViewModel: booksViewModel);
        }

        
    }
}