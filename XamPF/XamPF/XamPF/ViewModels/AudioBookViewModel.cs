using MvvmHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using XamPF.Services;

namespace XamPF.ViewModels
{
    public class AudioBookViewModel : BaseViewModel
    {
        public ObservableRangeCollection<BooksViewModel> Books { get; set; }

        public AudioBookViewModel()
        {
            Books = new ObservableRangeCollection<BooksViewModel>();

            foreach (var item in Repository.Books)
            {
                Books.Add(new BooksViewModel(item));
            }
        }

    }
}
