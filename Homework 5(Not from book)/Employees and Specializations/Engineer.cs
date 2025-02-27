// Written By Aaron Paatela
// 2/24/2025

// This is the Engineer subclass for Homework 5 Problem 2


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees_and_Specializations
{
    internal class Engineer : Employee
    {
        // variables
        private string employeeSpecialization = "unknown";

        // Gets and Sets
        public string EmployeeSpecialization
        {
            get { return this.employeeSpecialization; }
            set { this.employeeSpecialization = value; }
        }


        // Constructors

        public Engineer() : this("unknown", "n/a", 0)
        {

        }

        public Engineer(string _employeeSpecialization, string _employee, double _salary) : base(_employee, _salary)
        {
            this.employeeSpecialization = _employeeSpecialization;
        }

        public override string ToString()
        {
            string message = $"Employee: {EmployeeName}\nSalary: {EmployeeSalary}" +
                $"\nSpecialization: {EmployeeSpecialization}";
            return message;
        }

    }
}
