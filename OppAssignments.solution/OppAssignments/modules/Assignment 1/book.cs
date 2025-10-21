using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace OppAssignments.modules
{





    /// ASSIGNMENT 1 BOOKS
        public class book
    {
        public book(string title, string author, int year, string ISBN)
        {
            this.title = title;
            this.author = author;
            this.year = year;
            this.ISBN = ISBN;

        }
        public string title { get; set; }
        public string author { get; set; }
        public decimal year { get; set; }
        public string ISBN { get; set; }

        public void PrintBookInfo()
        {
            Console.WriteLine("----------------------------");
            Console.WriteLine($"Title: {title}");
            Console.WriteLine($"Author: {author}");
            Console.WriteLine($"Year: {year}");
            Console.WriteLine($"ISBN: {ISBN}");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n");

        }
        public bool IsOlderThan(int targetedYear)
        {
            return year < targetedYear;
        }
    }






}
