// Written By Aaron Paatela
// 2/27/2025

// This is the E-Book subclass for Homework 5 Problem 5


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_System
{
    public class EBook : Book
    {
        // Variables (Fields)
        private double fileSizeMB = 0;

        // Gets and Sets
        public double FileSizeMB
        {
            get { return this.fileSizeMB; }
            set { this.fileSizeMB = value; }
        }

        // Constructors
        public EBook() : this("n/a", "n/a", 0, 0)
        {

        }

        public EBook(string _BookTitle, string _BookAuthor, int _YearPublished, double _FileSizeMB) : 
            base(_BookTitle, _BookAuthor, _YearPublished)
        {
            this.FileSizeMB = _FileSizeMB;
        }

        // Methods

        public override string ToString()
        {
            return $"{BookTitle} By {BookAuthor}, Written {YearPublished}.\n" +
                $"E-book version: File size {FileSizeMB}MB";
        }
    }
}
