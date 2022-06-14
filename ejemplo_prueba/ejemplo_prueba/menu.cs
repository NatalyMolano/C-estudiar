using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo_prueba
{
    internal class menu
    {
        public void Menu()
        {
            double transport_subsidy = 117_172;
            data mydata = new data();
            Console.WriteLine("Enter the num of document: ");
            mydata.Document = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the first name: ");
            mydata.Firstname = Console.ReadLine();
            Console.WriteLine("Enter the last name");
            mydata.Lastname = Console.ReadLine();
            Console.WriteLine("Enter your salary: ");
            mydata.Salary =  double.Parse(Console.ReadLine());
            Console.WriteLine("register the workday");
            mydata.Workdays = double.Parse(Console.ReadLine());

            if(mydata.Salary <= 2_000_000)
            {
                mydata.Total_income = mydata.Salary + transport_subsidy;
            }
            else
            {
                mydata.Total_income = mydata.Salary;
            }

            mydata.Accrual = mydata.Salary * mydata.Workdays / 30;
            mydata.Health1 = mydata.Workdays - 0.04;
            mydata.Pension1 = mydata.Workdays - 0.04;

            Console.WriteLine("\nDate register of employee: \n");
            Console.WriteLine("Num Document: " + mydata.Document);
            Console.WriteLine("Firtsname: " + mydata.Firstname);
            Console.WriteLine("Lastname: " + mydata.Lastname);
            Console.WriteLine("Salary: " + mydata.Salary);
            Console.WriteLine("Workdays: " + mydata.Workdays);
            Console.WriteLine("Total_income: " + mydata.Total_income);
            Console.WriteLine("Accrual: " + mydata.Accrual);
            Console.WriteLine("Health: " + mydata.Health1);
            Console.WriteLine("Pension: " + mydata.Pension1);
        }
    }
}
