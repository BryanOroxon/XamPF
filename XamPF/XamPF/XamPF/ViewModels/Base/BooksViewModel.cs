using MvvmHelpers;
using System;
using System.Collections.Generic;
using System.Text;
using XamPF.Models;

namespace XamPF.ViewModels
{
    public class BooksViewModel : BaseViewModel
    {
        public string Name_Book { get; set; }

        public string Author_Book { get; set; }

        public double Price_Book { get; set; }

        public double Popularity_Level_Book { get; set; }

        public double Popularity_Counter_Book { get; set; }

        public string Image_Book { get; set; }

        public string MainColor { get; set; }

        public string AccentColor { get; set; }

        public BooksViewModel(Book book)
        {
            this.Name_Book = book.Name_Book;
            this.Author_Book = book.Author_Book;
            this.Price_Book = book.Price_Book;
            this.Popularity_Level_Book = book.Popularity_Level_Book;
            this.Popularity_Counter_Book = book.Popularity_Counter_Book;
            this.Image_Book = book.Image_Book;
            this.MainColor = book.MainColor;
            this.AccentColor = book.AccentColor;
        }
    }
}
