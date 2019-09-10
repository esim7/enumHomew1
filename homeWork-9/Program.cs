using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWork_9
{
    class Program
    {
        static void Main(string[] args)
        {
            //задание 1
            int clerkAvgWage = 0, clerkCount = 0;
            Console.WriteLine("Введите количество менеджеров работающих в Вашей компании");
            int size = int.Parse(Console.ReadLine());
            WorkOficce office = new WorkOficce();
            Employee boss = new Employee();
            Console.WriteLine("Введите Вашу фамилию(Вы босс фирмы)");
            string bossName = Console.ReadLine();
            boss._surname = bossName;
            boss._position = "босс";
            boss._wage = 987000;
            boss._employmentYear = 2001;
            Array.Resize(ref office._employees, office.__employeesCount + size);
            for (int i = office.__employeesCount; i < office._employees.Length; i++)
            {
                Employee employee = new Employee();
                Console.WriteLine("Введите фамилию сотрудника ");
                employee._surname = Console.ReadLine();
                Console.WriteLine("Введите оклад сотрудника ");
                employee._wage = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите год приема на работу");
                employee._employmentYear = int.Parse(Console.ReadLine());
                office._employees[i] = employee;
            }
            Array.Sort(office._employees); //сортируем массив всех работников фирмы по фамилии
            for (int i = 0; i < office._employees.Length; i++)
            {
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine($"Фамилия: {office._employees[i]._surname}");
                Console.WriteLine($"Должность: {office._employees[i]._position}");
                Console.WriteLine($"Оклад (тенге): {office._employees[i]._wage}");
                Console.WriteLine($"Год приема: {office._employees[i]._employmentYear}");
                Console.WriteLine("--------------------------------------------------");
                if(office._employees[i]._position.ToLower() == "клерк")
                {
                    clerkAvgWage += office._employees[i]._wage; //находим всех клерков из массива и определяем их общую ЗП
                    clerkCount++;
                }               
            }
            clerkAvgWage /= clerkCount; //определяем ср. ЗП всех клерков
            Console.WriteLine("Информация о менеджерах чья ЗП выше средней ЗП клерков");
            for(int i = 0; i < office._employees.Length; i++) 
            {
                if (office._employees[i]._position.ToLower() == "менеджер" && office._employees[i]._wage > clerkAvgWage)
                {
                    Console.WriteLine("--------------------------------------------------");
                    Console.WriteLine($"Фамилия: {office._employees[i]._surname}");
                    Console.WriteLine($"Должность: {office._employees[i]._position}");
                    Console.WriteLine($"Оклад (тенге): {office._employees[i]._wage}");
                    Console.WriteLine($"Год приема: {office._employees[i]._employmentYear}");
                    Console.WriteLine("--------------------------------------------------");
                }
            }
            Console.WriteLine("Информация о всех сотрудниках кто принят позже боссса(т.е после 2001 года)");
            for (int i = 0; i < office._employees.Length; i++)
            {
                if(office._employees[i]._employmentYear > boss._employmentYear)
                {
                    Console.WriteLine("--------------------------------------------------");
                    Console.WriteLine($"Фамилия: {office._employees[i]._surname}");
                    Console.WriteLine($"Должность: {office._employees[i]._position}");
                    Console.WriteLine($"Оклад (тенге): {office._employees[i]._wage}");
                    Console.WriteLine($"Год приема: {office._employees[i]._employmentYear}");
                    Console.WriteLine("--------------------------------------------------");
                }
            }
            Console.ReadKey();
        }
    }
}
