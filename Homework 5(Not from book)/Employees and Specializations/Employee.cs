// Written By Aaron Paatela
// 2/24/2025

// This is the base Employee class for Homework 5 Problem 2


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees_and_Specializations
{
    public class Employee
    {
        //variables
        private string employeeName = "n/a";
        private double employeeSalary = 0;


        // gets and sets

        public string EmployeeName
        {
            get { return this.employeeName; }
            set { this.employeeName = value; }
        }
        public double EmployeeSalary
        {
            get { return this.employeeSalary; }
            set { this.employeeSalary = value; }
        }

        // Constructors

        public Employee() : this("n/a", 0)
        {

        }

        public Employee(string _employeeName, double _employeeSalary)
        {
            this.EmployeeName = _employeeName;
            this.employeeSalary = _employeeSalary;
        }

        // methods
        public override string ToString()
        {
            string message = $"Employee: {EmployeeName}\nSalary: {EmployeeSalary}";
            return message;
        }
    }
}
