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
            double number=double.Parse(Console .ReadLine());
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
            double firstvalue=getdouble("enter the  first value:");
            double secondvalue=getdouble("enter the secondvalue:");
            if(firstvalue==secondvalue)
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
            int firstvalue=getinteger("enter the first value");
            int secondvalue=getinteger("enter the secndvalue");
            int thirdvalue=getinteger("enter the thirdvalue");
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
                if (firstvalue >secondvalue)
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
            int firstvalue=getinteger("enter the  firstvalue");
            int secondvalue=getinteger("enter the secondvalue");
            int thirdvalue=getinteger("enter the thirdvalue");
            int firstdif=Math.Abs(firstvalue-secondvalue);
            int seconddif=Math.Abs(secondvalue-thirdvalue);
            int thirddif=Math.Abs(firstvalue-thirdvalue);
            if(firstdif<seconddif)
            {
                if (firstdif>seconddif)
                {
                    Console.WriteLine("the second and third are farther each other");
                }
                else  if(seconddif<thirddif)

                {
                    if (seconddif>thirddif)
                    {
                        Console.WriteLine("the first and third values are farther to each other");
                    }
                }
                else
                {
                    if(firstdif<thirddif)
                    {
                        Console.WriteLine(" the first and second value are farther to each other" );
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

        }
}
