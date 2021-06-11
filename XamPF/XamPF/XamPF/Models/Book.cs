using System;
using System.Collections.Generic;
using System.Text;

namespace XamPF.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Name_Book { get; set; }
        public string Author_Book { get; set; }
        public double Price_Book { get; set; }
        public double Popularity_Level_Book { get; set; }
        public double Popularity_Counter_Book { get; set; }
        public string Image_Book { get; set; }
        public string MainColor { get; set; }
        public string AccentColor { get; set; }
        public string Url_Audio { get; set; }
    }
}
