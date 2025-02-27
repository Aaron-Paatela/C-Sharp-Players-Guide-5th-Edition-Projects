// Written By Aaron Paatela
// 2/27/2025

// This is the Printed Book subclass for Homework 5 Problem 5


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_System
{
    public class PrintedBook : Book
    {
        // Variables (Fields)
        private int pageCount = 0;

        // Gets and Sets
        public int PageCount
        {
            get { return this.pageCount; }
            set { this.pageCount = value; }
        }

        // Constructors

        public PrintedBook()
        {

        }

        public PrintedBook(string _BookTitle, string _BookAuthor, int _YearPublished, int _PageCount)
            : base(_BookTitle, _BookAuthor, _YearPublished)
        {
            this.PageCount = _PageCount;
        }

        // Methods

        public override string ToString()
        {
            return $"{BookTitle} By {BookAuthor}, Written {YearPublished}" +
                $"\nPage Count: {PageCount}";
        }
    }
}
