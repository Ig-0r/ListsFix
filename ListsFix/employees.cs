using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ListsFix
{
    internal class employees
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double Salary { get; private set; }

        public employees(int id, string name, double salary)
        {
            ID = id;
            Name = name;
            Salary = salary;
        }
        public void SalaryAdd(double percentage)
        {
            Salary += Salary * percentage / 100.0;
        }

        public override string ToString()
        {
            return "ID: "
                + ID
                + ", Name: "
                + Name
                + ", Salary: "
                + Salary.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
