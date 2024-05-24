using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClassLibrary2
{
    public class Dll
    {
        public int FirstNum { get; set; }
        public int SecondNum { get; set; }
        public int ResultNum { get; set; }

        public StringBuilder sb = new StringBuilder();
        public void BestFunc()
        {
            Console.WriteLine("Никита Шмалюк");
            try
            {
                Console.Write("Введите первое число: ");
                FirstNum = int.Parse(Console.ReadLine());

                Console.Write("Введите второе число: ");
                SecondNum = int.Parse(Console.ReadLine());
                ResultNum = FirstNum - SecondNum;

                if (ResultNum == 0)
                {
                    sb.Append("ноль");
                    Console.WriteLine(sb.ToString());
                }

                if (ResultNum == 1000)
                {
                    sb.Append("одна тысяча");
                    Console.WriteLine(sb.ToString());
                }

                if (ResultNum > 1000)
                {
                    throw new My_Exception("слишком большое число");
                }

                if (ResultNum < 0)
                    sb.Append("минус ");

                switch (ResultNum / 100)
                {
                    case 1:
                        sb.Append("сто "); break;
                    case 2:
                        sb.Append("двести "); break;
                    case 3:
                        sb.Append("триста "); break;
                    case 4:
                        sb.Append("четыреста "); break;
                    case 5:
                        sb.Append("пятьсот "); break;
                    case 6:
                        sb.Append("шестьсот "); break;
                    case 7:
                        sb.Append("семьсот "); break;
                    case 8:
                        sb.Append("восемьсот "); break;
                    case 9:
                        sb.Append("девятьсот "); break;
                }

                switch (ResultNum / 10 % 10)
                {
                    case 1:
                        sb.Append(""); break;
                    case 2:
                        sb.Append("двадцать "); break;
                    case 3:
                        sb.Append("тридцать "); break;
                    case 4:
                        sb.Append("сорок "); break;
                    case 5:
                        sb.Append("пятьдесят "); break;
                    case 6:
                        sb.Append("шестьдесят "); break;
                    case 7:
                        sb.Append("семьдесят "); break;
                    case 8:
                        sb.Append("восемьдесят "); break;
                    case 9:
                        sb.Append("девяносто "); break;
                }

                switch (ResultNum >= 200 ? ResultNum % 10 : ResultNum % 20)
                {
                    case 1:
                        sb.Append("один"); break;
                    case 2:
                        sb.Append("два"); break;
                    case 3:
                        sb.Append("три"); break;
                    case 4:
                        sb.Append("четыре"); break;
                    case 5:
                        sb.Append("пять"); break;
                    case 6:
                        sb.Append("шесть"); break;
                    case 7:
                        sb.Append("семь"); break;
                    case 8:
                        sb.Append("восемь"); break;
                    case 9:
                        sb.Append("девять"); break;
                    case 10:
                        sb.Append("десять"); break;
                    case 11:
                        sb.Append("одиннадцать"); break;
                    case 12:
                        sb.Append("двенадцать"); break;
                    case 13:
                        sb.Append("тринадцать"); break;
                    case 14:
                        sb.Append("четырнадцать"); break;
                    case 15:
                        sb.Append("пятнадцать"); break;
                    case 16:
                        sb.Append("шестнадцать"); break;
                    case 17:
                        sb.Append("семнадцать"); break;
                    case 18:
                        sb.Append("восемнадцать"); break;
                    case 19:
                        sb.Append("девятнадцать"); break;
                }

                Console.WriteLine($"{FirstNum} - {SecondNum} = {sb.ToString().Trim()}");

                Console.WriteLine("Программа завершена без ошибок. Нажмите любую клавишу, чтобы продолжить...");

                Console.ReadKey();
            }
            catch (My_Exception my_exception)
            {
                Console.ReadKey();
            }
            catch (FormatException)
            {
                Console.WriteLine("Некорректный ввод");

                Console.WriteLine("Программа завершена из за ошибки. Нажмите любую клавишу, чтобы продолжить...");
                Console.ReadKey();
            }
        }
        public class My_Exception : Exception
        {
            public My_Exception(string mes)
            : base(mes)
            {
                Console.WriteLine("слишком большое число");
            }
        }
    }
}