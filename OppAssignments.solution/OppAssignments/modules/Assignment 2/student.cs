using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppAssignments.modules
{
    public class student
    {

        public student(int id, string name)

        {
            this.id = id;
            this.name = name;
            this.grades = new List<int> ();
        }

        public int id { get; set; }
        public string name { get; set; }
        public List<int> grades { get; set; }




        public void AddGrade(int grade) { 
                   
            if (grade >= 0 && grade <= 100)
        {
            grades.Add(grade);
        }
        else
        {
            Console.WriteLine($"Invalid! must be between 0 and 100.");
        }
    }



        public double CalcAverage()
        {
            if (grades.Count == 0)
            {
                return 0.0;
            }

            int sum = 0;
            for (int i = 0; i < grades.Count; i++)
            {
                sum = sum + grades[i];
            }

            double average = (double)sum / grades.Count;
            return average;
        }

        public string GetLetterGrade(double average)
        {
            if (average >= 90) return "A";
            else if (average >= 80) return "B";
            else if (average >= 70) return "C";
            else if (average >= 50) return "D";
            else return "F";
        }

        public void PrintStudentReport()
        {
            Console.WriteLine("Student Report");
            Console.WriteLine("----------------------------");
            Console.WriteLine("Name: " + name);
            Console.WriteLine("ID: " + id);
            Console.WriteLine("Number of Grades: " + grades.Count);

        }


    }



}
