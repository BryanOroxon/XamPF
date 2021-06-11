using MvvmHelpers;
using System;
using System.Collections.Generic;
using System.Text;
using XamPF.Models;

namespace XamPF.ViewModels
{
    public class BooksViewModel : BaseViewModel
    {
        private string name_book;
        private string author_book;
        private double price_book;
        private double popularity_level_book;
        private double popularity_counter_book;
        private string image_book;
        private string mainColor;
        private string accentColor;

        public string Name_Book
        {
            get => name_book;
            set => SetProperty(ref name_book, value);
        }

        public string Author_Book
        {
            get => author_book;
            set => SetProperty(ref author_book, value);
        }

        public double Price_Book
        {
            get => price_book;
            set => SetProperty(ref price_book, value);
        }

        public double Popularity_Level_Book
        {
            get => popularity_level_book;
            set => SetProperty(ref popularity_level_book, value);
        }

        public double Popularity_Counter_Book
        {
            get => popularity_counter_book;
            set => SetProperty(ref popularity_counter_book, value);
        }

        public string Image_Book
        {
            get => image_book;
            set => SetProperty(ref image_book, value);
        }

        public string MainColor
        {
            get => mainColor;
            set => SetProperty(ref mainColor, value);
        }

        public string AccentColor
        {
            get => accentColor;
            set => SetProperty(ref accentColor, value);
        }

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
