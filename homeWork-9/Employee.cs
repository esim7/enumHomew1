using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWork_9
{
    class Employee : IComparable<Employee>
    {
        public string _surname { get; set; }
        public string _position { get; set; }
        public int _wage { get; set; }
        public int _employmentYear { get; set; }

        public Employee()
        {
            _surname = "";
            _position = "менеджер";
            _wage = 0;
            _employmentYear = 0;
        }

        public Employee(string Name, string Position, int Wage, int Year)
        {
            _surname = Name;
            _position = Position;
            _wage = Wage;
            _employmentYear = Year;
        }

        public int CompareTo(Employee employee) //реализация интерфейса 
        {
            return this._surname.CompareTo(employee._surname);
        }
    }
}
