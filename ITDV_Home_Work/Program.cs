using System;

namespace ITDV_Home_Work
{
    class Program
    {
        static void Main(string[] args)
        {

            /* 
                Lesson # 0             
                 * Язык программирования?
                 * Название C#?
                 * Консоль?
                 * Консольное приложение?
                 * Парадигма?
                 * Парадигма программирования?
                 * Алгоритм?
                 * Процедурная парадигма программирования?
             */
            /* 
                Lesson # 1             
                * Компилятор ?
                * IDE ?
                * Visual Studio?
                * Проект?
                * Исполняемый файл?            
            */
            /* 
                Lesson # 2             
                * Комментарии  ?
                * Маркеры или токены ?                           
            
                // UNDONE: Will be dispalyed in TAsk List -> View>Task LIst
                // TODO: Will be dispalyed in TAsk List -> View>Task LIst
                // HACK: Will be dispalyed in TAsk List -> View>Task LIst
            */
            /* 
                Lesson # 3             
                * Синтаксический сахар  ?
                * Фреймворк?
                * Решение ?
                * Intellisence ?
                * Метод?
                * Свойства?
                *  ctrl + E, D   ctrl+K, D ?
                *  ctrl + W   ctrl+J?
                *  Crete 2nd Project right click on Solution and select new Project
            */
            Console.WriteLine("---------------");
            Console.ForegroundColor = ConsoleColor.Red;   // Устанавливаем цвет букв
            Console.BackgroundColor = ConsoleColor.White; // Устанавливаем цвет фона
            Console.WriteLine("Hello World!");
            Console.ResetColor();  // Сбрасываем настройки цвета букв и фона
            Console.WriteLine("Hello World!");
            

            /* 
                Lesson # 4             
                * Псевдокод?
                * Диаграмма Насси-Шнейдермана?
                * Блок-схема?
                * Рефакторинг?
                * Скрам?               
            */
            /* 
                Lesson # 5             
                * Переменная?
                * Величина?
                * Натуральные числа?
                * Целые числа?
                * Скрам?               
            */

            int peaches = 8;
            int apples = 5;
            double halfApple = 0.05;
            double total = peaches + apples + halfApple;
            Console.WriteLine("---------------");
            Console.WriteLine("Total amount of fruits " +total);
            

            /* 
               Lesson # 6             
               * Бит ?
               * Байт ?
               * Оперативная память или ОЗУ?            
                             
           */
            /* 
               Lesson # 7             
               * Система счисления ?
               * Непозиционная система счисления ?
               * Позиционная система счисления?
               * Смешанные системы счисления?
               * Разряд?
               * Двоичная система счисления?
               * Шестнадцатеричная система счисления?
               * 
           */
            /* 
               Lesson # 8             
               * Основанием системы ?
               * Двоичная система счисления?               
           */
            /* 
               Lesson # 9             
               * Компиляция  ?
               * Машинный код ?
               * Переменная ?
               
           */
            /* 
               Lesson # 10             
               * Псевдоним   ?
               * Decimal ?
               * Кастинг  ?
               * Неявное преобразование типа ?
               * Явное преобразование типа?              
               
           */
            decimal changeTo = 3.1415926536M;
            int toInt = (int)changeTo;            
            byte toByte = (byte)changeTo;
            long toLong = (long)changeTo;
            var toVar = changeTo;
            float toFloat = (float)changeTo;
            short toShort = (short)changeTo;

            Console.WriteLine("---------------");
            Console.WriteLine("Decimal " + changeTo);
            Console.WriteLine("Int " + toInt);
            Console.WriteLine("Byte " + toByte);
            Console.WriteLine("Long " + toLong);
            Console.WriteLine("Float " + toFloat);
            Console.WriteLine("Short " + toShort);
            Console.WriteLine("Var " + toVar);
            

            /* 
              Lesson # 11             
              * Математическое выражение   ?
              * Арифметическая операция ?
              * Oперандами  ?
              * CIL (Common Intermediate Language) ?
              * Step Over?
              * Точка останова (англ. breakpoint)?
              * программе dotPeek?

          */
            int fNumber = 2;
            int sNumber =  3;
            sbyte subTotal = (sbyte)(fNumber + sNumber);
            sbyte difTotal = (sbyte)(fNumber - sNumber);
            Console.WriteLine("------------");
            Console.WriteLine("Total: " + subTotal + " Total: " + difTotal);
            

            /* 
              Lesson # 12            
              * Арифметические операторы   ?
              * Бинарные арифметические операторы ?
              * Операнд ?
              * Унарный  ?
              * Оператор инкремента (++)?
              * Префиксная операция инкремент?
              * Постфиксная операция инкремента ?
              * Оператор декремента (--) ?
              * Префиксная операция декремент?
              * NaN?
              * Операция составного присваивания?

          */
            Console.WriteLine("------------");
            int x = 10, y = 12, z = 3;
            Console.WriteLine("X: " + x + " Y: " + y + " Z: " + z);
            x += y - x++ * z;
            Console.WriteLine("X = "+x);
            z = --x - y * 5;
            Console.WriteLine("Z = " + z);
            y /= x + 5 % z;
            Console.WriteLine("Y =" + y);
            z = x++ + y * 5;
            Console.WriteLine("Z = " + z);
            x = y - x++ * z;
            Console.WriteLine("X = " + x);

           /* 
              Lesson # 13             
              * Строковой литерал   ?
              * char ?
              * ASCII   ?
              * Юникод  ?
              * UTF-16?    
          */
           Console.WriteLine("---------");
           Console.WriteLine("Please enter any text ");
           string userInput = Console.ReadLine();
           for (int i = 0; i < userInput.Length; i++)
              {
                Console.WriteLine(userInput[i]);
              }            
          

            /* 
               Lesson # 14             
               * Конкатенация (Объединение строк)   ?
               * Форматированный вывод ?
               * Маркер подстановки  ?
               * Строка составного формата  ?
               * Интерполяция?
               * Флаги форматирования?
               * Форма Бэкуса-Наура?
               * Константа (Constant)?
               * Правила использования констант?
               * Эскейп последовательности?
               *  \b  Backspace  
               * \n  Новая строка 
               * \r  Возврат каретки 
               * \t  Горизонтальная табуляция 
               * \v  Вертикальная табуляция  
           */
            Console.WriteLine("--------");
            Console.WriteLine("Please Enter Your First Name");
            string fName = Console.ReadLine();
            Console.WriteLine("Please Enter Your Last Name");
            string lName = Console.ReadLine();
            Console.WriteLine($"Hello {fName} {lName}! "+
                "\n"+ "It`s a god day today!");
            

           /* 
              Lesson # 15             
              * Высказывание ?
              * Пропозициональная логика ?
              * Модальная логика ?
              *  равно   “==” 
              *  не равно   “!=” 
              *  меньше   “<” 
              *  больше   “>” 
              *  меньше или равно  “<=” 
              *  больше или равно  “>=”.
          */
            Console.WriteLine("--------");
            int firstNum = 1;
            int secondNum = 2;
            Console.WriteLine(firstNum == secondNum);
            Console.WriteLine(firstNum != secondNum);
            Console.WriteLine(firstNum > secondNum);
            Console.WriteLine(firstNum < secondNum);
            
            /* 
               Lesson # 16             
               * Логические операции ?
               * Отрицание  ?
               * Конъюнкция  ?
               * Короткозамкнутая конъюнкци?
               *  Дизъюнкция? 
               *  Короткозамкнутая дизъюнкция? 
               *  Исключающее «ИЛИ»?
               *  меньше или равно  “<=” 
               *  больше или равно  “>=”.
           */

            Console.WriteLine("----------");
            Console.WriteLine("How many years you have been working for this company?");
            int clientInput = Convert.ToInt32(Console.ReadLine());

            if (clientInput < 5)
            {
                Console.WriteLine("Your bounus is 10%");
            }
            if (clientInput > 5 & clientInput <= 10)
            {
                Console.WriteLine("Your bounus is 15%");
            }
            if (clientInput > 11 & clientInput <= 15)
            {
                Console.WriteLine("Your bounus is 25%");
            }
            if (clientInput > 16 & clientInput <= 20)
            {
                Console.WriteLine("Your bounus is 35%");
            }
            if (clientInput > 21 & clientInput <= 25)
            {
                Console.WriteLine("Your bounus is 45%");
            }
            if (clientInput > 26)
            {
                Console.WriteLine("Your bounus is 50%");
            }
            
            /* 
               Lesson # 17             
               * Оператор побитового отрицания ?
               * Побитовое отрицание   ?
               * Побитовое И  ?
               * Побитовое исключающее ИЛ?
               * Битовая маска?
               * Битовые сдвиги?
               * Логический сдвиг?
               * Арифметический сдвиг?
               * Циклический сдвиг?              

           */         

            x += y >> x++ * z; 
            z = ++x & y * 5; 
            y /= x + 5 | z;
            z = x++ & y * 5;
            x = y << x++ ^ z;
            Console.WriteLine("----------------");
            Console.WriteLine($"X:{x} Y:{y} Z:{z}");
            Console.WriteLine("Please Eneter one character");
            char encryChar = Convert.ToChar(Console.ReadLine());
            Console.WriteLine($"Original Value enetered is : {encryChar} ");
            ushort enctyKey = 216;
            Console.WriteLine($"Key is  : {enctyKey} ");
            char encrypValue = (char)(encryChar ^ enctyKey);
            Console.WriteLine($"Encrypted Value: {encrypValue}");
            char decryptValue = (char)(encrypValue ^ enctyKey);
            Console.WriteLine($"Decrypted Value: {decryptValue}");

            /* 
               Lesson # 18             
               * Pascal casing  ?
               * Camel casing   ?
               * Uppercase  ?
               * Венгерская нотация ?
               * Статическая типизация ?
               * Динамическая типизация?
               * Неявно-типизированная локальная переменная var ?                      

           */
            /* 
               Lesson # 19             
               * Составной оператор   ?
               * Область видимости переменной   ?
               * Сокрытие имени   ?
               * Локальные переменны ?                              

           */
            Console.WriteLine("----------");

            Console.ReadLine();
        }
    }
}
