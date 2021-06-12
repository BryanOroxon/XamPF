using System;
using System.Collections.Generic;
using System.Text;
using XamPF.Models;

namespace XamPF.Services
{
    public static class Repository
    {

        static Repository()
        {
            #region Book List
            List<Book> books = new List<Book>
            {
                new Book
                {
                    Id=1,
                    Name_Book="Brave New World",
                    Author_Book="Aldous H.",
                    Price_Book=14.25,
                    Popularity_Level_Book=4.1,
                    Popularity_Counter_Book=94,
                    Image_Book="https://raw.githubusercontent.com/danielmonettelli/Area51/main/Books/img_brave_new_world.png",
                    MainColor="#FF7948",
                    AccentColor="#FC9773"
                },
                new Book
                {
                    Id=2,
                    Name_Book="The Old Man and the Sea",
                    Author_Book="Ernest Hemingway",
                    Price_Book=19.45,
                    Popularity_Level_Book=5,
                    Popularity_Counter_Book=99,
                    Image_Book="https://raw.githubusercontent.com/danielmonettelli/Area51/main/Books/img_the_old_man_and_the_sea.png",
                    MainColor="#2BBC89",
                    AccentColor="#9BEBCF"
                },
                new Book
                {
                    Id=3,
                    Name_Book="1984",
                    Author_Book="George Orwell",
                    Price_Book=14.99,
                    Popularity_Level_Book=5,
                    Popularity_Counter_Book=58,
                    Image_Book="https://raw.githubusercontent.com/danielmonettelli/Area51/main/Books/img_1984.png",
                    MainColor="#026555",
                    AccentColor="#0B787E"
                },
                new Book
                {
                    Id=4,
                    Name_Book="Pride and Prejudice",
                    Author_Book="Jane Austen",
                    Price_Book=19.99,
                    Popularity_Level_Book=4.6,
                    Popularity_Counter_Book=94,
                    Image_Book="https://raw.githubusercontent.com/danielmonettelli/Area51/main/Books/img_pride_and_prejudice.png",
                    MainColor="#F8BA94",
                    AccentColor="#F8BA94"
                },
                new Book
                {
                    Id=5,
                    Name_Book="The Lord of the Flies",
                    Author_Book="William Golding",
                    Price_Book=13.49,
                    Popularity_Level_Book=3.8,
                    Popularity_Counter_Book=88,
                    Image_Book="https://raw.githubusercontent.com/danielmonettelli/Area51/main/Books/img_the_lord_of_the_flies.png",
                    MainColor="#FF7948",
                    AccentColor="#FC9773"
                },
                new Book
                {
                    Id=6,
                    Name_Book="Farenheit",
                    Author_Book="J.K. Rowling",
                    Price_Book=22.49,
                    Popularity_Level_Book=4.0,
                    Popularity_Counter_Book=67,
                    Image_Book="https://raw.githubusercontent.com/danielmonettelli/Area51/main/Books/img_farenheit.png",
                    MainColor="#F17C1F",
                    AccentColor="#F29750"
                },
            };
            #endregion

            Books = new List<Book>(books);
        }

        public static List<Book> Books;
    }
}
