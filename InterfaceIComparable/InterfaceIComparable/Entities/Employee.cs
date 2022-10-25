using System;
using System.Collections.Generic;
using System.Globalization;


namespace InterfaceIComparable.Entities
{
    internal class Employee : IComparable
    {
        public string Name { get; set; }
        public double Salary { get; set; }
        public Employee(string csvEmployee)
        {
            string[] vect = csvEmployee.Split(',');
            Name = vect[0];
            Salary = double.Parse(vect[1], CultureInfo.InvariantCulture);
        }
        public override string ToString()
        {
            return Name + ", " + Salary.ToString("F2", CultureInfo.InvariantCulture);
        }

        public int CompareTo(object? obj)
        {
            // Tratamento para garantir que está recebendo ojtevo do tipo employee, pois o tipo object pode ser qualquer coisa.
            if (!(obj is Employee))
            {
                throw new ArgumentException("Comparing error: argument is not an Employee");
            }
            Employee other = obj as Employee;
            // Também é possível comparar´por salário.
            // Salary.CompareTo(other.Salary);
            return Name.CompareTo(other.Name);
        }
    }
}
