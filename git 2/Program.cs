using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace git_2
{
    class Program
    {
        static void Main(string[] args)
        {
            q12();



        }

        public static int getinteger(string message)
        {
            Console.WriteLine(message);
            int number = int.Parse(Console.ReadLine());
            return number;
        }
        public static double getdouble(string message)
        {
            Console.WriteLine(message);
            double number = double.Parse(Console.ReadLine());
            return number;
        }

        public static void q1()
        {
            int number = getinteger("enter the number of positive or negative or 0:");
            if (number == 0)
            {
                Console.WriteLine(" the number is zero");
            }
            else if (number > 0)
            {
                Console.WriteLine("the number is positive");
            }
            else if (number < 0)
            {
                Console.WriteLine("the number is negative ");
            }
            else
            {
                Console.WriteLine("invaild input");
            }
        }

        public static void q2()
        {
            int firstvalue = getinteger("enter the firstvalue:");
            int secondvalue = getinteger("enter the secondvalue:");
            if (firstvalue == secondvalue)
            {
                Console.WriteLine(" the equal number");
            }
            else if (firstvalue != secondvalue)
            {
                Console.WriteLine("the not equal number");
            }
            else
            {
                Console.WriteLine("inalid input");
            }
        }
        public static void q3()
        {
            double firstvalue = getdouble("enter the  first value:");
            double secondvalue = getdouble("enter the secondvalue:");
            if (firstvalue == secondvalue)
            {
                Console.WriteLine("the equal number");
            }
            else if (firstvalue != secondvalue)
            {
                Console.WriteLine("the not equal number");
            }
            else
            {
                Console.WriteLine("inalid input");
            }
        }
        public static void q4()
        {
            int number = getinteger(" check is the number is odd or even");
            if (number % 2 == 0)
            {
                Console.WriteLine(" even number");
            }
            else if (number % 2 != 0)
            {
                Console.WriteLine("even number");
            }
            else
            {
                Console.WriteLine("invaild number");
            }
        }

        public static void q5()
        {
            int year = getinteger(" check the leapyear");
            if (year % 4 == 0)
            {
                Console.WriteLine("the leapyear");
            }
            else if (year % 4 != 0)
            {
                Console.WriteLine(" not leapyear");
            }
            else
            {
                Console.WriteLine("invaild year");
            }
        }

        public static void q6()
        {
            int age = getinteger("check if you eligible for voting:");
            if (age >= 18)
            {
                Console.WriteLine("eliglible for the voting:");
            }
            else if (age < 18)
            {
                Console.WriteLine(" not eligible for the voting:");
            }
            else
            {
                Console.WriteLine("invalid input");
            }
        }
        public static void q7()
        {
            int height = getinteger("enter the height in centimeter ");
            if (height > 0 && height <= 140)
            {
                Console.WriteLine("short");
            }
            else if (height > 140 && height <= 160)
            {
                Console.WriteLine("medium:");
            }
            else if (height > 160)
            {
                Console.WriteLine("tall");
            }
        }
        public static void q8()
        {
            int firstvalue = getinteger("enter the first value");
            int secondvalue = getinteger("enter the secndvalue");
            int thirdvalue = getinteger("enter the thirdvalue");
            if (firstvalue > secondvalue)
            {
                if (firstvalue < secondvalue)
                {
                    Console.WriteLine(" secondvalue is contain largestnumber");
                }
                else
                {
                    Console.WriteLine("firstvaluse is contain largestnumber");
                }
            }
            else if (secondvalue > thirdvalue)
            {
                if (secondvalue < thirdvalue)
                {
                    Console.WriteLine("thirdvalue is contain largestnumber");
                }
                else
                {
                    Console.WriteLine("second value is contain largestnumber:");
                }
            }
            else
            {
                if (firstvalue > thirdvalue)
                {
                    Console.WriteLine("firstvalue is contain largest number:");
                }
                else
                {
                    Console.WriteLine("thirdvalue is contain largest number:");
                }
            }
        }
        public static void q9()
        {
            int firstvalue = getinteger("enter the first value");
            int secondvalue = getinteger("enter the secndvalue");
            int thirdvalue = getinteger("enter the thirdvalue");
            if (firstvalue < secondvalue)
            {
                if (firstvalue > secondvalue)
                {
                    Console.WriteLine(" secondvalue is contain smallestnumber");
                }
                else
                {
                    Console.WriteLine("firstvaluse is contain smllestnumber");
                }
            }
            else if (secondvalue < thirdvalue)
            {
                if (secondvalue > thirdvalue)
                {
                    Console.WriteLine("thirdvalue is contain smallestnumber");
                }
                else
                {
                    Console.WriteLine("second value is contain smallestnumber:");
                }
            }
            else
            {
                if (firstvalue < thirdvalue)
                {
                    Console.WriteLine("firstvalue is contain  smallestnumber:");
                }
                else
                {
                    Console.WriteLine("thirdvalue is contain smallestnumber:");
                }
            }
        }


        public static void q10()
        {
            int firstvalue = getinteger("enter the firstvalue");
            int secondvalue = getinteger("enter the secondvalue");
            int thirdvalue = getinteger("enter the thirdvalue");
            int fourthvalue = getinteger("enter the fourthvalue");
            int biggest = firstvalue;
            if (secondvalue > biggest)
            {
                biggest = secondvalue;
            }
            else if (thirdvalue > biggest)
            {
                biggest = thirdvalue;
            }
            else if (fourthvalue > biggest)
            {
                biggest = fourthvalue;
            }
            else
            {
                Console.WriteLine("invaild input");
            }
            Console.WriteLine("the biggest value is:" + biggest);
        }

        public static void q11()
        {
            int firstvalue = getinteger("enter the  firstvalue");
            int secondvalue = getinteger("enter the secondvalue");
            int thirdvalue = getinteger("enter the thirdvalue");
            int firstdif = Math.Abs(firstvalue - secondvalue);
            int seconddif = Math.Abs(secondvalue - thirdvalue);
            int thirddif = Math.Abs(firstvalue - thirdvalue);
            if (firstdif < seconddif)
            {
                if (firstdif > seconddif)
                {
                    Console.WriteLine("the second and third are farther each other");
                }
                else if (seconddif < thirddif)
                {
                    if (seconddif > thirddif)
                    {
                        Console.WriteLine("the first and third values are farther to each other");
                    }
                }
                else
                {
                    if (firstdif < thirddif)
                    {
                        Console.WriteLine(" the first and second value are farther to each other");
                    }
                }
            }
        }

        public static void q12()
        {
            int firstvalue = getinteger("enter the  firstvalue");
            int secondvalue = getinteger("enter the secondvalue");
            int thirdvalue = getinteger("enter the thirdvalue");
            int firstdif = Math.Abs(firstvalue - secondvalue);
            int seconddif = Math.Abs(secondvalue - thirdvalue);
            int thirddif = Math.Abs(firstvalue - thirdvalue);
            if (firstdif > seconddif)
            {
                if (firstdif < seconddif)
                {
                    Console.WriteLine("the second and third are close each other");
                }
                else if (seconddif > thirddif)
                {
                    if (seconddif < thirddif)
                    {
                        Console.WriteLine("the first and third values are close to each other");
                    }
                }
                else
                {
                    if (firstdif > thirddif)
                    {
                        Console.WriteLine(" the first and second value are close to each other");
                    }
                }
            }
        }

        public static void q13()
        {
            int firstvalue = getinteger("enter the first value:");
            int secondvalue = getinteger("enter the second value:");
            int thirdvalue = getinteger("enter the third value:");
            int biggest = Math.Max(firstvalue, secondvalue);
            int maxi = Math.Max(biggest, thirdvalue);
            int small = Math.Min(firstvalue, secondvalue);
            int minium = Math.Min(small, thirdvalue);
            int middle = (firstvalue + secondvalue + thirdvalue) - (maxi + minium);
            Console.WriteLine(minium);
            Console.WriteLine(middle);
            Console.WriteLine(maxi);
        }
        public static void q14()
        {
            Console.WriteLine(" enter three angles to check the given three angles:");
            int firstangle = getinteger("enter the first  angle");
            int secondangle = getinteger("enter the second angle");
            int thirdangle = getinteger("enter the third angle");
            int result = firstangle + secondangle + thirdangle;
            if (result == 180)
            {
                Console.WriteLine("the traingle canbe formed using these three angle");
            }
            else
            {
                Console.WriteLine("the traingle cannotbe formed using these three ");

            }
        }
        public static void q15()
        {
            int x = getinteger(" enter the value for x:");
            int y = getinteger(" enter the value for y:");
            if (x == 0 && y == 0)
            {
                Console.WriteLine(" it lies on the center ");
            }
            else if (x > 0 && y > 0)
            {
                Console.WriteLine("its lies on the first quratent:");
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine("its lies on the second quratent:");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("its lies on the third quratent:");
            }

            else
            {
                Console.WriteLine("invaild input");
            }
        }
        public static void q16()
        {
            Console.WriteLine("enter the any character:");
            char value = char.Parse(Console.ReadLine());
            switch (value)
            {
                case 'a':
                    {
                        Console.WriteLine("it is vowel");
                        break;
                    }
                case 'e':
                    {
                        Console.WriteLine("it is vowel");
                        break;
                    }
                case 'i':
                    {
                        Console.WriteLine("it is vowel");
                        break;
                    }
                case 'o':
                    {
                        Console.WriteLine("it is vowel");
                        break;
                    }
                case 'u':
                    {
                        Console.WriteLine("it is vowel");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("invalid input");
                        break;
                    }
            }


        }
        public static void q17()
        {
            int value = getinteger("entr the number of sides between (3 to 10) to find the shape:");
            switch (value)
            {
                case 3:
                    {

                        Console.WriteLine("traingle");
                        break;
                    }
                case 4:
                    {

                        Console.WriteLine("square");
                        break;
                    }
                case 5:
                    {

                        Console.WriteLine("pentagon");
                        break;
                    }
                case 6:
                    {

                        Console.WriteLine("hexagon");
                        break;
                    }
                case 7:
                    {

                        Console.WriteLine("heptagon");
                        break;
                    }
                case 8:
                    {

                        Console.WriteLine("octogan");
                        break;
                    }
                case 9:
                    {

                        Console.WriteLine("ennegon");
                        break;
                    }
                case 10:
                    {

                        Console.WriteLine("decagon");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("invalid input");
                        break;
                    }
            }

        }
        public static void q18()
        {
            Console.WriteLine("enter the month to find the number of days");
            string month = Console.ReadLine();
            switch (month.ToLower())
            {
                case "january":
                    {
                        Console.WriteLine("31days");
                        break;
                    }
                case "feb":
                    {
                        Console.WriteLine("28days");
                        break;
                    }
                case "march":
                    {
                        Console.WriteLine("31days");
                        break;
                    }
                case "april":
                    {
                        Console.WriteLine("31days");
                        break;
                    }
                case "may":
                    {
                        Console.WriteLine("31days");
                        break;
                    }
                case "june":
                    {
                        Console.WriteLine("30days");
                        break;
                    }
                case "july":
                    {
                        Console.WriteLine("31days");
                        break;
                    }
                case "augest":
                    {
                        Console.WriteLine("31days");
                        break;
                    }
                case "september":
                    {
                        Console.WriteLine("30days");
                        break;
                    }
                case "october":
                    {
                        Console.WriteLine("31days");
                        break;
                    }
                case "november":
                    {
                        Console.WriteLine("31days");
                        break;
                    }
                case "december":
                    {
                        Console.WriteLine("31days");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("invalid input");
                        break;
                    }


            }
        }
        public static void q19()
        {
            int week = getinteger("enter the date  find the day:");
            if (week % 7 == 0)
            {
                Console.WriteLine("sunday");
            }
            else if (week % 7 == 1)
            {
                Console.WriteLine("monday");
            }
            else if (week % 7 == 2)
            {
                Console.WriteLine("tuesday");
            }
            else if (week % 7 == 3)
            {
                Console.WriteLine("wednesday");
            }

            else if (week % 7 == 4)
            {
                Console.WriteLine("thursday");
            }
            else if (week % 7 == 5)
            {
                Console.WriteLine("friday");
            }
            else if (week % 7 == 6)
            {
                Console.WriteLine("saturday");
            }
            else
            {
                Console.WriteLine("invalid input");
            }

        }
        public static void q20()
        {
            Console.WriteLine("enter the length of size of a traingle to find the name of traingle");
            int firstlength = getinteger("enter the of sizd of 1 traingle");
            int secondlength = getinteger("enter the of sizd of 2 traingle");
            int thirdlength = getinteger("enter the of sizd of 3 traingle");
            if (firstlength == secondlength && firstlength == thirdlength)
            {
                Console.WriteLine("it is equality trainglle:");
            }
            else if (firstlength == secondlength || secondlength == thirdlength || firstlength == thirdlength)
            {
                Console.WriteLine("isosceles");

            }
            else
            {
                Console.WriteLine("scalene");
            }
        }



    }
}
