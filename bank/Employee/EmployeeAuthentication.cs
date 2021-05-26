using System;
using System.Collections.Generic;
using System.Text;
using bank.Sistemas;

namespace bank.Employee
{
    public abstract class EmployeeAuthentication : Employee, IAuthentication
    {
        public string password { get; set; }

        public bool Authentication(string password)
        {
            return this.password == password;
        }

        public EmployeeAuthentication(double salary,string cpf):base(salary, cpf)
        {

        }

    }
}