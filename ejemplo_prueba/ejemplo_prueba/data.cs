using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo_prueba
{
    internal class data
    {
        private double document;
        private string firstname;
        private string lastname;
        private double salary;
        private double workdays;
        private double total_income;
        private double accrual; //Devengo
        private double Health;
        private double Pension;

        public double Document { get => document; set => document = value; }
        public string Firstname { get => firstname; set => firstname = value; }
        public string Lastname { get => lastname; set => lastname = value; }
        public double Salary { get => salary; set => salary = value; }
        public double Workdays { get => workdays; set => workdays = value; }
        public double Total_income { get => total_income; set => total_income = value; }
        public double Accrual { get => accrual; set => accrual = value; }
        public double Health1 { get => Health; set => Health = value; }
        public double Pension1 { get => Pension; set => Pension = value; }
    }
}
