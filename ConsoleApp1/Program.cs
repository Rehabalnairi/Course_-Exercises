using System.Numerics;
using System.Runtime.ExceptionServices;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////1. Even or Odd
            //float number;
            //Console.WriteLine("Enter any Number");

            //number = float.Parse(Console.ReadLine());
            //if(number % 2 == 0)
            //{
            //    Console.WriteLine(number  +"is even");
            //}
            //else
            //{
            //    Console.WriteLine(number + "is odd");
            //}

            //-------------------------------------

            ////2) Largest of Three Numbers 
            //int num1,num2,num3;
            ////double result;
            //Console.WriteLine("Enter First Number");
            //num1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter seconed Number");
            //num2 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter thered  Number");
            //num3 = int.Parse(Console.ReadLine());
            //if(num1 >= num2 && num1 >= num3)
            //{
            //    Console.WriteLine(num1 + "is largest number");
            //}
            //else if(num2 >= num1 && num2 >= num3)
            //{
            //    Console.WriteLine(num2+ "is largest number");
            //}
            //else
            //{
            //    Console.WriteLine(num3 + "is largest number");
            //}


            //------------------------------------------------

            //3. Temperature Converter

            //float temp;
            //Console.WriteLine("Enter The Temperature in C");
            //temp = float.Parse(Console.ReadLine());
            //double result;
            //result = (temp * 9 / 5) + 32;
            //Console.WriteLine(result+"F")
            //;

            //----------------------

            //4. Simple Discount Calculator
            //double price;
            //double disc;
            //double total;
            //Console.WriteLine("Enter Price");
            // price = double.Parse(Console.ReadLine());
            //disc = (price * 10) / 100;
            //total = price - disc;
            // if (price > 100)
            //{
            //    Console.WriteLine(" Your total price is " + total);
            //}
            //else
            //{
            //    Console.WriteLine(" Your total price is " + price);
            //}

            //5. Grading System
            //    float StudentMark;

            //    Console.WriteLine(" Enter your Mark ");
            //    StudentMark = float.Parse(Console.ReadLine());
            //    if (StudentMark >= 90 && StudentMark <= 100)
            //    {
            //        Console.WriteLine("your grade is A ");
            //    }
            //    else if (StudentMark >= 80 && StudentMark <= 89)
            //        {
            //        Console.WriteLine("your grade is B ");
            //    }
            //    else if (StudentMark >= 70 && StudentMark <= 79)
            //        {
            //        Console.WriteLine("your grade is C ");
            //    }

            //    else if (StudentMark >= 60 && StudentMark <= 69)
            //    {
            //        Console.WriteLine("your grade is D ");
            //    }

            //    else if (StudentMark <= 60)
            //    {
            //        Console.WriteLine("your grade is F ");
            //    }
            //    else
            //    {
            //        Console.WriteLine(" Enter your  correct Mark ");
            //    }

            //another soluation 
            //Console.WriteLine("enter student Mark");
            //int score = int.Parse(Console.ReadLine());
            //char grade;
            //    if (score >= 90)
            //{
            //    grade = 'A';

            //}else if (score>= 80)
            //{
            //    grade = 'B';
            //}
            //   else if  (score >= 70)
            //{
            //    grade = 'C';
            //}
            //else if (score >= 60)
            //{
            //    grade = 'D';
            //}
            //else
            //{
            //    grade = 'F';
            //}
            //Console.WriteLine("The student grade is :" + grade);




            //}
            //------------------------------------------------------
            //6)Swap Two Numbers
            //int num1, num2 ;
            //Console.WriteLine(" Enter first number ");
            //num1 = int.Parse(Console.ReadLine());
            //Console.WriteLine(" Enter second number ");
            //num2 = int.Parse(Console.ReadLine());

            //int n = num1;
            //num1 = num2;
            //num2 = n;
            //Console.WriteLine(" Numbers After swap ");
            //Console.WriteLine(" Number1 After swap :" + num1);
            //Console.WriteLine(" Number2 After swap :" + num2);

            //--------------------------------------
            //7. Days to Weeks and Days Converter 
            //int days;
            //Console.WriteLine("enter number of days");
            //days = int.Parse(Console.ReadLine());
            //int week = days / 7;
            //int remainingDays = days % 7;

            //Console.WriteLine(days + " days = " + week + " week(s) and " + remainingDays + " day(s)");
            //Console.WriteLine("-------------------------------------------------");










            //----------------------------------

            //8. Electricity Bill Calculator
            //float Units;
            //Console.WriteLine("Enter the Units: \n");
            //Units = int.Parse(Console.ReadLine());
            //if (Units < 100)
            //{
            //    Console.WriteLine(Units * 0.5);
            //}
            //else if (Units < 300)
            //{
            //    Console.WriteLine(Units * 0.75);
            //}
            //else if (Units > 301)
            //{
            //    Console.WriteLine(Units * 1);
            //}

            //------------------------------------------------
            //9. Simple Calculator

            //     float num1, mun2;
            //// string operator;
            // Console.WriteLine(" Enter first number ");
            // num1 = float.Parse(Console.ReadLine());
            // Console.WriteLine(" Enter second  number ");
            // mun2 = float.Parse(Console.ReadLine());


            //// operator=Console.ReadLine();
            ///

            //////-----------------------------------------------------------

            //////Simple Calculator
            //Console.Write("Enter first number: ");
            //double FirstNumber = double.Parse(Console.ReadLine());

            //Console.Write("Enter operator (+, -, *, /): ");
            //char op = Console.ReadKey().KeyChar;
            //Console.WriteLine();

            //Console.Write("Enter second number: ");
            //double SecondNumber = double.Parse(Console.ReadLine());

            //double result = 0;

            //if (op == '+')
            //    result = FirstNumber + SecondNumber;
            //else if (op == '-')
            //    result = FirstNumber - SecondNumber;
            //else if (op == '*')
            //    result = FirstNumber * SecondNumber;
            //else if (op == '/')
            //{
            //    if (SecondNumber != 0)
            //        result = FirstNumber / SecondNumber;
            //    else
            //    {
            //        Console.WriteLine("Cannot divide by zero!");
            //        return;
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Invalid operator!");
            //    return;
            //}

            //Console.WriteLine("Result: " + result );
            //Console.WriteLine("-------------------------------------------------");

            ////-----------------------------------------------


            //Console.WriteLine("Enter a number");
            //int n = int.Parse(Console.ReadLine());
            //int counter;
            //for (counter = 0; counter<= n; counter++)
            //{
            //    Console.WriteLine("Rehab");
            //}

            //int num = 20;
            //while (num != 20)
            //{
            //    Console.WriteLine("guess a number");
            //    num = int.Parse(Console.ReadLine());

            //}
            //----------------------------------------------


            //int num = 0;

            //do
            //{
            //    Console.WriteLine("guess a number ");
            //    num = int.Parse(Console.ReadLine());
            //}
            //while (num != 20);
            //------------------------------

            //# Part2 Exercises

            //1. Simple Calculator (Switch-Case)
            //   Console.WriteLine("Enter First Number:");
            //   int num1 = int.Parse(Console.ReadLine());

            //   Console.WriteLine("Enter second Number:");
            //   int num2 = int.Parse(Console.ReadLine());
            //   Console.WriteLine("Enter operator (+, -, *, /): ");
            //   char op = Console.ReadKey().KeyChar;
            ////   Console.WriteLine();

            //   double result = 0;
            //   switch (op)
            //   {
            //       case '+':
            //           result = num1 + num2;
            //           Console.WriteLine("result is" + result);
            //           break;

            //       case '-':
            //           result = num1 - num2;
            //           Console.WriteLine("result is" + result);
            //           break;

            //       case '/':
            //           result = num1 / num2;
            //           Console.WriteLine("result is" + result);
            //           break;
            //       case '*':
            //           result = num1 * num2;
            //           Console.WriteLine("result is" + result);
            //           break;

            //       default:
            //           Console.WriteLine("error");
            //           break;

            //   }
            //---------------------------------------------------------------------------
            //2. Basic ATM System
            //Console.WriteLine("Enter your balance ");
            //int balance = int.Parse(Console.ReadLine());
           
            //if (balance >= 1000)
            //    Console.WriteLine("choose options \n 1. Withdraw Money \n 2. Deposit Money \n 3. Check Balance  \n 4. Exit ");
            //char ch = Console.ReadKey().KeyChar;
            //{
            //    switch (ch)
            //    {
            //        case 1:
            //            break;
            //    }

            //}

            //--------------------------------------
            //Console.WriteLine("choose a shape :1.Circle,2.Square,3.Triangle");
            //char shape = char.Parse(Console.ReadLine());

            //switch (shape)
            //{
            //    case '1':
            //        Console.WriteLine("Enter the radius: ");
            //        double radius = double.Parse(Console.ReadLine());
            //         double area = radius * radius * Math.PI;
            //        double cir = 2 + radius * Math.PI;
            //        Console.WriteLine("area is : "+area+"Circumference is:"+cir);

            //        break;

            //    case '2':

            //        Console.WriteLine("Enter the side length: ");
            //        double length = double.Parse(Console.ReadLine());
            //        double areasq = length * length;
            //        double premeter = length * 4;
            //        Console.WriteLine("area is : " + areasq + "perimeter  is:" + premeter);
            //        break;
            //    case '3':
            //        Console.WriteLine("Enter the Length: ");
            //        double Length = double.Parse(Console.ReadLine());
            //        Console.WriteLine("Enter the base: ");
            //        double baseLength = double.Parse(Console.ReadLine());
            //        double trangleare = 0.5 * Length * baseLength;
            //        Console.WriteLine("area is :" + trangleare);

            //        break;
            //        default:
            //        Console.WriteLine("error");
            //        break;
            //-------------------------------------------------------
            // Factorial of a Number  
            //Console.WriteLine("Enter First Number:");
            //int num1 = int.Parse(Console.ReadLine());
            //float Factorial = 1;

            //for (int i =1;i<= num1; i++)
            //{
            //    Factorial *= i;
            //}
            //Console.WriteLine("Factorial is:"+Factorial);


            //---------------------------------------------

            //5. Sum of Even and Odd Numbers 
            //Console.WriteLine("Enter Number:");
            //int num = int.Parse(Console.ReadLine());
            //int oddNum=0;
            //int sumEven = 0;

            //for (int i = 1; i <= num; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        sumEven = ++i;
            //    }
            //    else
            //        oddNum += i;
            //        Console.WriteLine("sum of even Numbers:" + sumEven + "sum of odd Numbers:"+oddNum);
            //}

            //6. Scientific Calculator (Switch-Case & Math Functions)
            //Console.WriteLine("choose  an operation :1.sin/2.cos/3.tan/4.sqrt/5.log/6.pow");
            //char op = char.Parse(Console.ReadLine());
            //double result = 0;
            //switch(op)
            //{
            //    case '1':
            //        Console.WriteLine("Enter a Number");
            //        double Nsin = double.Parse(Console.ReadLine());
            //        result = Math.Sin(Nsin);
            //        Console.WriteLine(result);
            //        break;

            //    case '2':
            //        Console.WriteLine("Enter a Number");
            //        double Ncos = double.Parse(Console.ReadLine());
            //        result = Math.Cos(Ncos);
            //        Console.WriteLine(result);
            //        break;

            //    case '3':
            //        Console.WriteLine("Enter a Number");
            //        double Ntan = double.Parse(Console.ReadLine());
            //        result = Math.Tan(Ntan);
            //        Console.WriteLine(result);
            //        break;

            //    case '4':
            //        Console.WriteLine("Enter a Number");
            //        double Nsqrt = double.Parse(Console.ReadLine());
            //        result = Math.Sqrt(Nsqrt);
            //        Console.WriteLine(result);
            //        break;

            //    case '5':
            //        Console.WriteLine("Enter a Number");
            //        double Nlog = double.Parse(Console.ReadLine());
            //        result = Math.Log(Nlog);
            //        Console.WriteLine(result);
            //        Console.WriteLine(result);
            //        break;

            //    case '6':
            //        Console.WriteLine("Enter a Number");
            //        double Npow = double.Parse(Console.ReadLine());
            //        Console.WriteLine("Enter a Number");
            //        double Npow1 = double.Parse(Console.ReadLine());
            //        result = Math.Pow(Npow,Npow1);
            //        Console.WriteLine(result);
            //        break;


            //    default:
            //        Console.WriteLine("error");
            //        break;
            //}
            //-------------------------------------------------------------------------------------------
            //7. Print Pattern (For Loop)

            //Console.WriteLine("enter a number ");
            //int n = int.Parse(Console.ReadLine());
            //string x = "";
            //int i;

            //    for (i = 1; i <= n; i++)
            //    {

            //    for (int j = 1; j <= i; j++)
            //    {
            //        x += "*";


            //    }
            //    Console.WriteLine(x);
            //    x = "";

            //}
            //Console.WriteLine();
            //-------------------------------------------

            //8. Print a Pyramid Pattern (For Loop)

            //Console.WriteLine("enter a number ");
            //int n = int.Parse(Console.ReadLine());
            //string x = "";
            //int i;

            //for (i = 1; i <n ; i++)
            //{

            //    for (int j = 1; j <n-i -1; j++)
            //    {
            //       // x += "*";
            //        Console.Write(" ");

            //        for (int k = 1; k < 2 * i + 1; k++)
            //        {
            //            Console.Write("*");
            //        }


            //    }
            //    Console.WriteLine(x);
            //   //x= "";

            //}
            //Console.WriteLine();

            //----------------------------

            //Console.WriteLine("enter  number ");
            //int n = int.Parse(Console.ReadLine());
            ////string x = "";
            ////int i;
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < n -i ; j++)
            //    {
            //        Console.Write("");

            //    }
            //    for (int k = 0; k < 2 * i + 1; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();

            //}

            //for (int i = n - 2; i >= 0; i--)
            //{

            //    for (int j = 0; j < n - i ; j++)
            //    {
            //        Console.Write(" ");
            //    }

            //    for (int k = 0; k < 2 * i + 1; k++)
            //    {
            //        Console.Write("*");
            //    }

            //    Console.WriteLine();
            //}


            //-------------------------------------
            //9. Print a Diamond Pattern (For Loop)

            //Console.WriteLine("enter  number ");
            //int n = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= n; i++)

            //{
            //    for (int j = 1; j <= n - i; j++) 
            //    { Console.Write(" "); }
            //    for (int k = 1; k <= 2 * i - 1; k++) 
            //    { Console.Write("*"); }
            //    Console.WriteLine(); 
            //}

            //for (int i = n - 2; i >= 0; i--)
            //{

            //    for (int j = 0; j < n - i; j++)
            //    {
            //        Console.Write(" ");
            //    }

            //    for (int k = 0; k < 2 * i + 1; k++)
            //    {
            //        Console.Write("*");
            //    }

            //    Console.WriteLine();
            //}

            //-----------------------------------


        }


    }
 

    }



