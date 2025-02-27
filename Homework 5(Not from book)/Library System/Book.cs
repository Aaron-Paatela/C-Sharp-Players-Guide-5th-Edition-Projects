// Written By Aaron Paatela
// 2/27/2025

// This is the base Book class for Homework 5 Problem 5


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_System
{
    public class Book
    {
        // Variables
        private string bookTitle = "n/a";
        private string bookAuthor = "n/a";
        private int yearPublished = 0;

        // Gets and Sets
        public string BookTitle
        {
            get { return this.bookTitle; }
            set { this.bookTitle = value; }
        }
        public string BookAuthor
        {
            get { return this.bookAuthor; }
            set { this.bookAuthor = value; }
        }
        public int YearPublished
        {
            get { return this.yearPublished; }
            set { this.yearPublished = value; }
        }

        // Constructors
        public Book() : this("n/a", "n/a", 0)
        {

        }
        public Book(string _BookTitle,  string _BookAuthor, int _YearPublished)
        {
            this.BookTitle = _BookTitle;
            this.BookAuthor = _BookAuthor;
            this.YearPublished = _YearPublished;
        }

        // Methods

        public override string ToString()
        {
            return $"{BookTitle} By {BookAuthor}, Written {YearPublished}";
        }
    }
}
