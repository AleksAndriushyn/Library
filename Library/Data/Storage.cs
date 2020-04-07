using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Library.Models;

namespace Library.Data
{
    public class Storage
    {
        public static void Initialize(LibraryContext context)
        {
            context.Database.EnsureCreated();


            var books = new Books[]
            {
            new Books{title = "War and peace", pages = 200},
            new Books{title ="The Old Man and the Sea", pages = 550},
            new Books{title="It", pages = 1200},
            new Books{title="Three comrades", pages = 300},
            new Books{title="The Picture of Dorian Grey", pages = 720}
            };

            foreach (Books b in books)
            {
                context.Books.Add(b);
            }


            var authors = new Author[]
            {
            new Author{firstName = "Lev", lastName = "Tolstoy", dateOfBirth = new DateTime(1828, 09, 9), books_amount = 50},
            new Author{firstName = "Ernest", lastName = "Hemingway", dateOfBirth = new DateTime(1899, 07, 21), books_amount = 100},
            new Author{firstName = "Stephen", lastName = "King", dateOfBirth = new DateTime(1947, 09, 21), books_amount = 75},
            new Author{firstName = "Erich", lastName = "Remark", dateOfBirth = new DateTime(1898, 06, 22), books_amount = 120},
            new Author{firstName = "Oscar", lastName = "Wilde", dateOfBirth = new DateTime(1854, 10, 16), books_amount = 130}
            };

            foreach (Author a in authors)
            {
                context.Authors.Add(a);
            }
            

            var chapters = new Chapter[]
            {
            new Chapter{title = "The beginning of hero's life"},
            new Chapter{title = "To the stars!"},
            new Chapter{title = "New Life"},
            new Chapter{title = "The God"},
            new Chapter{title = "Adventure begins"}
            };

            foreach (Chapter c in chapters)
            {
                context.Chapters.Add(c);
            }


            var readers = new Reader[]
            {
            new Reader{firstName = "Dmitry", lastName = "Gordon"},
            new Reader{firstName = "Elon", lastName = "Musk"},
            new Reader{firstName = "Johnny", lastName = "Depp"},
            new Reader{firstName = "Tom", lastName = "Hanks"},
            new Reader{firstName = "Ariana", lastName = "Grande"}
            };

            foreach (Reader r in readers)
            {
                context.Readers.Add(r);
            }
            

            var readers_cards = new Readers_Card[]
            {
            new Readers_Card{firstName = "Dmitry", lastName = "Gordon", date = new DateTime(1967, 10, 21), book_title = "War and peace"},
            new Readers_Card{firstName = "Elon", lastName = "Musk", date = new DateTime(1967, 06, 28), book_title = "The Old Man and the Sea"},
            new Readers_Card{firstName = "Johnny", lastName = "Depp", date = new DateTime(1963, 06, 09), book_title = "The Picture of Dorian Grey"},
            new Readers_Card{firstName = "Tom", lastName = "Hanks", date = new DateTime(1956, 07, 09), book_title = "Three comrades"},
            new Readers_Card{firstName = "Ariana", lastName = "Grande", date = new DateTime(1993, 06, 26), book_title = "It"}
            };

            foreach (Readers_Card rc in readers_cards)
            {
                context.Readers_Cards.Add(rc);
            }
            

            var authors_books = new Authors_Book[]
            {
            new Authors_Book{firstName = "Lev", lastName = "Tolstoy", book_title = "War and peace"},
            new Authors_Book{firstName = "Ernest", lastName = "Hemingway", book_title = "The Old Man and the Sea"},
            new Authors_Book{firstName = "Stephen", lastName = "King", book_title = "It"},
            new Authors_Book{firstName = "Erich", lastName = "Remark", book_title = "Three comrades"},
            new Authors_Book{firstName = "Oscar", lastName = "Wilde", book_title = "The Picture of Dorian Grey"}
            };

            foreach (Authors_Book ab in authors_books)
            {
                context.Authors_Books.Add(ab);
            }
            context.SaveChanges();
        }
    }
}
