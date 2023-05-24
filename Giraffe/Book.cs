using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe
{
    internal class Book
    {
        public string Title;
        public int Pages ;
        public string Author ;

        //CONSTRUCTOR
        public Book(string aTitle , string aAuthor , int aPages)
        {
            Title = aTitle;
            Author = aAuthor;
            Pages = aPages;
        }

        //TEST

        //public int MinusPages(int pages)
        //{
        //    return pages - 100;
        //}
    }
}
