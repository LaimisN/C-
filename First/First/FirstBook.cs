using System;
using System.Collections.Generic;
using System.Text;

namespace First
{
    class FirstBook
    {
        /*class is spesification ant int the program file we create OBJECT BOOK
        public string title;
        public string author;
        public int pages;
        public FirstBook(string name)
        {
            Console.WriteLine(name);
        }
        */

        public string title;
        public string author;
        public int pages;
        public FirstBook()
        {

        }
        public FirstBook(string aTitle, string aAuthor, int aPages)
        {
            title = aTitle;
            author = aAuthor;
            pages = aPages;


        }


    }
}
