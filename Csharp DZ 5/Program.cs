using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public struct DateTime
    {
        public int Hours { get; set; }
        public int Minutes { get; set; }
        public DateTime(int value1, int value2)
        {
            Hours = value1;
            Minutes = value2;
        }
        public override string ToString()
        {
            return $"{Hours}:{Minutes}";
        }
    }
    public class Factory
    {
        public string Name { get; set; }
        public Employee[] Employees;
        public Factory(Employee[] employees)
        {
            Employees = employees;
        }
        public Product[] Products;
        public Factory(Product[] products)
        {
            Products = products;
        }
        /////////
        public override string ToString()
        {
            for (int i = 0; i < Employees.Length; i++)
            {
                Console.WriteLine(Employees[i]);
            }
            for (int i = 0; i < Products.Length; i++)
            {
                Console.WriteLine(Products[i]);
            }
            return $"Name: {Name}\n";
        }
        public decimal AvgSalary()
        {
            decimal sum = 0;
            for (int i = 0; i < Employees.Length; i++)
            {
                sum = sum + Employees[i].Salary;
            }
            sum = sum / Employees.Length;
            return sum;
        }
        public decimal TotalSalary()
        {
            decimal sum = 0;
            for (int i = 0; i < Employees.Length; i++)
            {
                sum = sum + Employees[i].Salary;
            }
            return sum;
        }
        public decimal EmpCount()
        {
            return Employees.Length;
        }
    }
    public class Employee
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public decimal Salary { get; set; }

        public Employee(decimal salary)
        {
            Salary = salary;
        }

        public DateTime BirthDate { get; set; }
        public string Phone { get; set; }
        /////////
        public Employee()
        {
            Name = "";
            Surname = "";
            Salary = 0;
            Phone = "";
        }
        public override string ToString()
        {
            return $"Name: {Name}\nSurname: {Surname}\nSalary: {Salary}\nPhone: {Phone}\nDate of birth:{BirthDate}\n";
        }
    }
    public class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }
        public readonly DateTime ManufactureDate;
        /////////
        public override string ToString()
        {
            return $"Name: {Name}\nPrice: {Price}\nPhone: {Category}\nManufactureDate: {ManufactureDate}\n";
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}