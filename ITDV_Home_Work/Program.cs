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

            Console.WriteLine("Please Enter LocalVarible");
            int LocalVarible = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"LocalVarible is {LocalVarible}");
            {
                LocalVarible = 10;
                Console.WriteLine(LocalVarible);
            }
            {
                LocalVarible = 15;
                Console.WriteLine(LocalVarible);
            }

            /* 
              Lesson # 20             
              * Блок  ?
              * Область видимости переменной  ?
              * Структурный подход  ?
              * Structured Programming ?
              * Время жизни переменной?
              * Окно уязвимости?
              * Принцип близости ?                      

          */

            Console.WriteLine("----------");
            {
                int sum;
                {
                    int a = 10,  b = 20, c = 30;
                    sum = a + b + c;
                }
                int dif;
                {
                    int o = 50, p = 100, q = 250;
                    dif = q - p - o;
                    
                }
                double Total = dif/sum  ;

                Console.WriteLine($"Total is {Total}");
            }

           /* 
              Lesson # 21             
              * checked  ?
              * unchecked ?                          

          */
            unchecked // uncheked by defult if we selct checked we will get an error of overfloww 

            {
                int aa = int.MaxValue;
                int bb = aa + 1;
                Console.WriteLine(aa);
                Console.WriteLine(bb);
            }

            /* 
              Lesson # 22             
              * Величина  ?
              * Константа ?                          

          */
            Console.WriteLine("----------");
            Console.WriteLine("Plese Eneter a Double ");
            double UserEnter = Convert.ToDouble(Console.ReadLine());
            const double PI = 3.141593;
            const bool My_CONST = true;

            bool  iSConstBigger = PI == UserEnter;

            Console.WriteLine($"iSConstBigger ? {iSConstBigger == My_CONST }");

            /* 
              Lesson # 23             
              * Алгоритм  ?
              * линейные алгоритмы ? 
              * алгоритмами ветвления?
              * Ветвление?
              * if?
              * else if?
              * ветвлением в полной форме.?
              * Явное сравнение?
              * Неявное сравнение?

          */

            Console.WriteLine("----------");
            Console.WriteLine("Plese Eneter a Number ");

            int userInputs = Convert.ToInt32(Console.ReadLine());

            if (userInputs >= 3)
            {
                userInputs += 10;
            }
            else {
                userInputs *= 10;
            }
            Console.WriteLine(userInputs);


            /* 
             Lesson # 24             
             * Гибкость  ?
             * Сложность кода ? 
             * Цикломатическая сложность?
            

         */

            /* 
            Lesson # 25             
            * Ctrl + K + D  ?
            * true ? 
            * false ?
            * Пустой оператор?


        */

            Console.WriteLine("-------------");
            Console.WriteLine("Please Enter first side ");
            int firstSide = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Enter seconde side ");
            int secondeSide = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Enter P fro Perimiter or A for Area");
            string PerimetOrArea = Console.ReadLine();
            double Area = firstSide * secondeSide;
            double Perimeter = firstSide * secondeSide / 2;

            if (PerimetOrArea == "P") 
            {
                Console.WriteLine($"Perimet is: {Perimeter}");
            }
            if (PerimetOrArea == "A")
            {
                Console.WriteLine($"Are is : {Area}");
            }
            if(PerimetOrArea != "A" && PerimetOrArea != "P" ) {
                Console.WriteLine("Wrong Input ");
            }


       /* 
           Lesson # 26            
           * switch-case ?
           * выражение-селектор? 
           * постоянным выражением. ?
           * Оператор break ?


       */


            Console.WriteLine("-------------");
            Console.WriteLine("Please Enter first number ");
            int numOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Enter seconde number ");
            int numTwo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please select operation  +, -, /, *");
            string operation = Console.ReadLine();
            double summ, diff, mul, div;
            switch (operation) 
            {
                case ("+"):
                    {
                        summ = numOne + numTwo;
                        Console.WriteLine(summ);
                        break;
                    }
                case ("-"):
                    {
                        diff = numOne - numTwo;
                        Console.WriteLine(diff);
                        break;
                    }
                case ("*"):
                    {
                        mul = numOne * numTwo;
                        Console.WriteLine(mul);
                        break;
                    }
                case ("/"):
                    {
                        div = numOne / numTwo;
                        Console.WriteLine(div);
                        break;
                    }
                default:
                    {
                      
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"Wrong Operator");
                        break;
                    }
            }


            /* 
              Lesson # 27            
              * Тернарный оператор [ ? : ] ?
              * Стэк?   
            */
            Console.WriteLine("-------------");
            Console.WriteLine("Please Enter first number ");
            int numX = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Enter seconde number ");
            int numY = Convert.ToInt32(Console.ReadLine());

            numX = numX % 2 == 0 ? numX : numX + 1;
            numY = numY % 2 == 0 ? numY : numY + 1;

            Console.WriteLine($"numX: {numX} and numY: {numY}");

            string result = (numX + numY) % 2 == 0 ? $"Total of {numX} and {numY} can be divided on 4 " : $"Total of {numX} and {numY} can not  be divided on 4";
            Console.WriteLine(result);


            /* 
              Lesson # 28            
              * Цикл ?
              * Итерация? 
              * while ?
              * do-while ?
            */


            Console.WriteLine("-------------");
            Console.WriteLine("Please Enter a Number");
            int numberA = Convert.ToInt32(Console.ReadLine());

            while (numberA >= 0)
            {
                Console.WriteLine(numberA);
                numberA --;
            }

            Console.WriteLine("Please Enter a 1st Number");
            int numberB = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Enter a 2nd Number");
            int numberC = Convert.ToInt32(Console.ReadLine());

            while (numberC >= 0)
            {
                if (numberB == numberC)
                {
                    break;
                }
                if (numberC % 3 == 0)
                {
                    Console.WriteLine(numberC);
                }
                numberC--;
                numberB++;
                
            }


            /* 
              Lesson # 29            
              * break, ?
              * continue? 
              * Array ?
              * Index ?
              * empty Array?
            */
            Console.WriteLine("-------------");

            string[] months = { "Jan", "Feb","Mar","Apr","May","Jun" };
            

            int index = 0;
            while (months.Length > index)
            {

                Console.WriteLine("Plese Enter name of the month");
                string answer = Console.ReadLine();

                if (answer == months[index])
                {
                    Console.WriteLine(months[index]);
                    index++;
                }
                if (index == 4 && Console.ReadLine() != months[4]) 
                {
                    Console.WriteLine("Wrong Answer");
                    break;
                }
                else
                {
                    Console.WriteLine("Try on emore time ");
                    continue;
                }
                
            }


            /* 
             Lesson # 30            
             * CopyTo(array, Int32) ?
             * Array.Resize(ref array, Int32)? 
             * Алгоритм сортировки?
             * Quicksort ?
             * Реверсирование массива?
           */

            Console.WriteLine("-------------");

            Console.WriteLine("PLease Enter a length of array  ");
            int length = Convert.ToInt32(Console.ReadLine());
            int [] array = new int [length];

            int indexA = 0;
            while (array.Length >  indexA) 
            {
                Console.WriteLine("Plese eneter numbers you want to add to array ");
                array[indexA] = Convert.ToInt32(Console.ReadLine());
                indexA++;
            }

            Array.Resize(ref array, array.Length + 1);
            Console.WriteLine("Plese eneter new number you want to add to an array ");
            int newElemnt = Convert.ToInt32(Console.ReadLine());
            array[array.Length - 1] = newElemnt;
            Array.Reverse(array);


            int newIndx = 0;
            while (array.Length > newIndx)
            {
                Console.WriteLine(array[newIndx]);
                newIndx++;
            }


            /* 
            Lesson # 31            
            * Цикл for, ?
            * Array.Resize(ref array, Int32)? 
            * Алгоритм сортировки?
            * Quicksort ?
            * Реверсирование массива?
          */

            for (int i = 0; 100 > i; i++)
            {
                Console.WriteLine(i);
            }

            /* 
           Lesson # 32             
           * Двумерный массив?
           * GetLength? 
           * матрица?
           
         */

            Console.WriteLine("-------------");

            Console.WriteLine("PLease Enter a Row of array  ");
            int arrayRow = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("PLease Enter a Column of array  ");
            int arrayColumn = Convert.ToInt32(Console.ReadLine());
            int[,] firstArray2d = new int [arrayRow, arrayColumn];

            Console.WriteLine("PLease Enter a Row of 2nd array  ");
            int arrayRow2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("PLease Enter a Column of 2nd array  ");
            int arrayColumn2 = Convert.ToInt32(Console.ReadLine());
            int[,] secondArray2d = new int[arrayRow2, arrayColumn2];

            for (int i = 0; i < firstArray2d.GetLength(0); i++)
            {
                for (int j = 0; j < firstArray2d.GetLength(1); j++)
                {
                    Console.WriteLine("PLease Enter number for Array ");
                    int numberArray1 = Convert.ToInt32(Console.ReadLine());                   
                    firstArray2d[i, j] = numberArray1; 
                    
                }
               
            }


            {
                for (int i = 0; i < secondArray2d.GetLength(0); i++)
                {
                    for (int j = 0; j < secondArray2d.GetLength(1); j++)
                    {
                        Console.WriteLine("PLease Enter number for Array ");
                        int numberArray2 = Convert.ToInt32(Console.ReadLine());
                        secondArray2d[i, j] = numberArray2;

                    }

                }
            }
            Console.WriteLine("-------1st Aray-----");
            {
                for (int i = 0; i < firstArray2d.GetLength(0); i++)
                {
                    for (int j = 0; j < firstArray2d.GetLength(1); j++)
                    {
                       
                        Console.Write(firstArray2d[i, j]);
                    }
                    Console.WriteLine();
                }

            }
            Console.WriteLine("-------2nd Aray-----");
            {
                for (int i = 0; i < secondArray2d.GetLength(0); i++)
                {
                    for (int j = 0; j < secondArray2d.GetLength(1); j++)
                    {

                        Console.Write(secondArray2d[i, j]);
                    }
                    Console.WriteLine();
                }

            }


            /* 
         Lesson # 33             
         * Трехмерный массив?
         * набор двумерных таблиц.? 
         

       */

            Console.ReadLine();
        }
    }
}
