using System;
using System.Collections.Generic;
using System.Text;

namespace bank.Employee
{
    public abstract class Employee
    {
        public string name { get; set; }
        public string cpf { get; set; }
        public double salary { get; protected set; }
        public static int allEmployee { get; set; }
        public Employee(double salary, string cpf) {
            allEmployee++;
            this.cpf = cpf;
            this.salary = salary;
        }

        public abstract void IncreaseSalary();

    }
}
