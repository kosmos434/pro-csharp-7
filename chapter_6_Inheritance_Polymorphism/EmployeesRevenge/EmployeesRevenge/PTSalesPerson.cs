using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeesRevenge
{
    sealed class PTSalesPerson : SalesPerson
    {
        // Mega constructor. Chained from employee --> salesperson --> here
        public PTSalesPerson(string fullName, int age, int empID, float currPay, string ssn, int numbOfSales)
            :base(fullName, age, empID, currPay, ssn, numbOfSales)
        {
        }
    }
}
