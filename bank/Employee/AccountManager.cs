using System;
using System.Collections.Generic;
using System.Text;
using bank.Employee;
using bank.Sistemas;

namespace bank.Employee
{
    public class AccountManager:EmployeeAuthentication
    {
        public AccountManager(string cpf) : base(5000, cpf) { }
        public override void IncreaseSalary()
        {
            salary *= 1.1;
        }
    }
}
