using MvvmHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using XamPF.Services;

namespace XamPF.ViewModels
{
    public class AudioBookDetailViewModel : BaseViewModel
    {
        private readonly INavigation _navigation;
        public ICommand ReturnPreviousPageCommand { get; set; }
        public BooksViewModel SelectedBook { get; set; }

        public AudioBookDetailViewModel(INavigation navigation, BooksViewModel selectedBooksViewModel)
        {
            this._navigation = navigation;

            var selectedItem = Repository.Books.FirstOrDefault(f => f.Name_Book.Equals(selectedBooksViewModel.Name_Book));

            SelectedBook = new BooksViewModel(selectedItem);

            ReturnPreviousPageCommand = new Command(ReturnPreviousPage);
        }

        private async void ReturnPreviousPage()
        {
            await Task.Delay(350);
            await _navigation.PopModalAsync(true);
        }

    }
}
