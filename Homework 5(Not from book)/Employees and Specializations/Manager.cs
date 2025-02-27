// Written By Aaron Paatela
// 2/24/2025

// This is the Manager subclass for Homework 5 Problem 2


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees_and_Specializations
{
    public class Manager : Employee
    {
        // variables
        private int numberOfEmployeesManaged = 0;

        // gets and sets
        
        public int NumberOfEmployeesManaged
        {
            get { return this.numberOfEmployeesManaged; }
            set { this.numberOfEmployeesManaged = value; }
        }

        // Constructors

        public Manager(): this(0, "n/a", 0)
        {

        }

        public Manager(int _numberOfEmployeesManaged, string _employeename, double _employeesalary) : 
            base(_employeename, _employeesalary)
        {
            this.numberOfEmployeesManaged = _numberOfEmployeesManaged;
        }


        //methods

        public override string ToString()
        {
            string message = $"Employee: {EmployeeName}\nSalary: {EmployeeSalary}\n" +
                $"Number of people managed: {NumberOfEmployeesManaged}";
            return message;
        }


    }
}
