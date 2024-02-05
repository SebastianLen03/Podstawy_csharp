using System;
using System.ComponentModel;
using System.Data;
using System.Linq.Expressions;
using System.Text;

namespace FirstProject
{
    #region ProgramClassRegion          
    class Program
    {
        private static bool boolResult;

        /// <summary>
        /// main method description
        /// </summary>
        /// <param name="args">args description</param>
        static void Main(string[] args)
        {
            #region podstawy

            // single line comment

            /* this 
             * is
             * a
             * multi
             * line
             * comment 
             */

            /*
            Console.WriteLine("Hello, World!");

            Console.Write("jak masz na imię? ");
            string userName = Console.ReadLine();
            Console.Write("Witaj ");
            Console.WriteLine(userName);

            string Text = "tekst";

            char jChar = 'j';
            char jCharUnicode = '\u006A';

            bool isUserReadu = false;

            DateTime now = DateTime.Now;
            DateTime dateofBith = new DateTime(1999, 4, 23);

            byte byteNumber = 200;
            float floatNumber = 1.5F;
            decimal decimalNumber = 1.5M;
            double doubleNumber = 1.5;

            string message1;
            message1 = "some calue";
            Console.WriteLine(message1);

            string message2 = null;
            Console.WriteLine(message2);

            string message3 = string.Empty;
            Console.WriteLine(message3);

            string text = "Oj tak \"tak\"";
            string winLocation = "c:\\windows";                 
            Console.WriteLine(text);
            Console.WriteLine(winLocation);

            string fontsFolder = @"c:\windows\fonts";               
            Console.WriteLine(fontsFolder);

            string concat = string.Concat(text, "to ", "ww");
            string concat2 = text + "to " + "ww";
            Console.WriteLine(concat);
            Console.WriteLine(concat2);

            string interpolated = $"{text} to me";                  //interpolowanie
            Console.WriteLine(interpolated);

            StringBuilder sb = new StringBuilder("This ");
            sb.Append("is ");
            sb.AppendLine("end");

            string result = sb.ToString();
            Console.WriteLine(result);
            */

            /*
            int result;
            int x = 10;
            int y = 5;

            result = x + y;
            Console.WriteLine(result);

            result = x - y;
            Console.WriteLine(result);

            result = x * y;
            Console.WriteLine(result);

            result = x / y;
            Console.WriteLine(result);

            int value = 2 + 2 / 2; 
            Console.WriteLine(value); //3

            bool boolResult;

            boolResult = (x == y);
            Console.WriteLine("x == y: " + boolResult);

            boolResult = (x > y);
            Console.WriteLine("x > y: " + boolResult);

            boolResult = (x != y);
            Console.WriteLine("x != y: " + boolResult);

            bool a = true;
            bool b = false;

            boolResult = (a && b);
            Console.WriteLine("AND &&: " + boolResult);

            boolResult = (a || b);
            Console.WriteLine("OR ||: " + boolResult);

            boolResult = !a;
            Console.WriteLine("NOT !: " + boolResult);

            int greaterNumber = x > y ? x : y;
            Console.WriteLine("number: " + greaterNumber);
            */

            #endregion

            #region else if

            /*
            Console.WriteLine("rok urodzenia?");
            string userInput = Console.ReadLine();

            int yearOfBirth = int.Parse(userInput);
            bool isUserOver18 = DateTime.Now.Date.Year - yearOfBirth > 18;

            if(isUserOver18)
            {
                Console.WriteLine("hello");
            }
            else if(DateTime.Now.DayOfWeek == DayOfWeek.Sunday)
            {
                Console.WriteLine("it's sunday!");
            }
            else 
            {
                Console.WriteLine("acces denied");
            }

            Console.WriteLine("bye");
            #endregion
            */
            #endregion

            #region Switch

            /*
            switch (DateTime.Now.DayOfWeek)
            {
                case DayOfWeek.Monday:
                    Console.WriteLine("it's Monday");
                    break;
                case DayOfWeek.Friday:
                    Console.WriteLine("it's Friday");
                    break;
                case DayOfWeek.Sunday:
                case DayOfWeek.Saturday:
                    Console.WriteLine("weekend!");
                    break;
                default:
                    Console.WriteLine("Normal day!");
                    break;
            }
            */

            #endregion

            #region konwersja i rzutowanie
            /*
      
            string userInput = Console.ReadLine();

            //int yearOfBirth = int.Parse(userInput);

            int yearOfBirth;
            if(int.TryParse(userInput, out yearOfBirth))
            {
                int age = DateTime.Now.Year - yearOfBirth;
                Console.WriteLine("you are " + age);
            }
            else
            {
                Console.WriteLine("incorrect values");
            }
            //float floatValue = float.Parse(userInput);
            //short shortValue = short.Parse(userInput);

            byte byteValue = 100;
            int intValue = byteValue;
            byte byteValue2 = (byte)intValue;
            double doubleValue = 3.5;
            int intValue2 = (int)doubleValue;

            string stringValue2 = intValue2.ToString();
            */
            #endregion

            #region zadania

            /*
             * ile dni żyjesz
             */

            /*
            Console.WriteLine("podaj rok urodzin");
            int year = int.Parse(Console.ReadLine());

            Console.WriteLine("podaj miesiąc urodzin");
            int month = int.Parse(Console.ReadLine());

            Console.WriteLine("podaj dzień urodzin");
            int day = int.Parse(Console.ReadLine());

            DateTime dateofBith = new DateTime(year, month, day);

            TimeSpan timeSpan = DateTime.Now - dateofBith;

            Console.WriteLine($"you were born: {timeSpan.TotalDays} days ago");
            */

            /*
             * aplikacja wczytuje liczby użytkownika dopóki nie poda on liczby 0
             * oblicza sume podanych liczb
             * znajduje największy element
             */
            /*
            int userInput = 0;
            int sum = 0;
            int? maxValue = null;

            do
            {
                Console.WriteLine("Podaj dowolną liczbę");

                userInput = int.Parse(Console.ReadLine());

                if (userInput != 0)
                {
                    sum += userInput;
                }

                if(maxValue == null || userInput > maxValue)
                {
                    maxValue = userInput;
                }

            } while (userInput != 0);

            Console.WriteLine("suma = " + sum);
            Console.WriteLine("największa liczba = " + maxValue);
            */
            #endregion

            #region tablice

            /*
            string[] cars = { "Volvo", "Mazda", "BMW" };

            Console.WriteLine(cars[2]);

            int arrayLength = cars.Length; //3

            cars[2] = "Tesla";

            Console.WriteLine(cars[cars.Length - 1]);
            */
            #endregion

            #region pętla while
            /*
            string[] cars = { "Volvo", "Mazda", "BMW" };

            int i = 0;

            while (i <= cars.Length - 1)
            {
                Console.WriteLine(cars[i]);
                if (cars[i] == "Mazda")
                {
                    break;
                }
                i++;
            }
            */
            #endregion

            #region pętla do-while
            /*
            Console.WriteLine("to exit, type 'x'");

            string userInput;

            do
            {
                userInput = Console.ReadLine();
                Console.WriteLine($"Echo: {userInput}");
            } while (userInput != "x");
            */
            #endregion

            #region pętla for
            /*
            string[] cars = { "Volvo", "Mazda", "BMW" };

            for (int j = 0; j < cars.Length; j++)
            {
                Console.WriteLine(cars[j]);
                if (cars[j] == "Mazda")
                {
                    break;
                }
            }
            */
            #endregion

            #region pętla foreach
            /*
            string[] cars = { "Volvo", "Mazda", "BMW" };

            foreach(string car in cars)
            {
                Console.WriteLine(car);
                if(car == "Mazda")
                {
                    break;
                }
            }
            */
            #endregion

            #region enum
            /*
            Console.WriteLine("What is your gender? 1 - Male, 2 = Female");
            string userInpout = Console.ReadLine();

            Gender userGender = (Gender)Enum.Parse(typeof(Gender), userInpout);

            if(userGender == Gender.Male)
            {
                Console.WriteLine("Male");
            }
            else
            {
                Console.WriteLine("Female");
            }
            */
            #endregion

            #region nullable
            /*
            int? favoriteNumber = null;

            Console.WriteLine("Favorite number = " +  (favoriteNumber.HasValue ? favoriteNumber.Value.ToString() : ""));
            */
            #endregion

            #region Try catch finally

            /*
            string[] cars = { "Volvo", "BMW", "Mazda" };

            try
            {
                Console.WriteLine(cars[4]);
            }
            catch (Exception e)
            {
                Console.WriteLine("Zły element");
            }
            finally 
            {
                Console.WriteLine("Ta");
            }
            */
            #endregion

        }
    }
    #endregion
}

