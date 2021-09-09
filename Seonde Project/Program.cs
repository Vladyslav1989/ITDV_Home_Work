using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seonde_Project
{
    class Program
    {
        /*
           Lesson # 36            
        * Чёрный ящик,?
        *Метод? 
        *Процедуры?
        *Тело метода?
        *Сигнатура метода?
        *Формальный параметр?
        *Тип возвращаемого значения метода?
        *Формальный параметр?
        *Фактический параметр?
        *Метод Main?


      */

        static int Salary(int days, int pay)
        {
            int salary = days * pay;
            return salary;
        }
        static int SalaryT(int workers, int pay, int days)
        {
            int total = Salary(days, pay) * workers; 

            return total;
        }
        static void Main(string[] args)
        {
            int workers = 5;
            int  days = 5;
            int pay = 10;

            Console.WriteLine(SalaryT(workers, pay, days));

            Console.ReadKey();

            

        }
    }
}
