using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWork_9
{
    class WorkOficce
    {
        public Employee[] _employees;
        public int __employeesCount { get; set; }

        public WorkOficce() //для удобства я решил не заморачиваться, а сразу инициализировать клерков а пользователю дать инициализацию менеджеров
        {
            _employees = new Employee[] {
                new Employee("Пупкин", "клерк", 95000, 1995),
                new Employee("Сидоров", "клерк", 88000, 2012),
                new Employee("Иванов", "клерк", 98500, 2010),
                new Employee("Федоров", "клерк", 90000, 2008),
                new Employee("Федотов", "клерк", 91500, 2000),
                new Employee("Яковлев", "клерк", 105000, 2007),
                new Employee("Судаков", "клерк", 88500, 1998),
                new Employee("Баранов", "клерк", 101000, 2000),
            };
            __employeesCount = _employees.Length;
        }
}
}
