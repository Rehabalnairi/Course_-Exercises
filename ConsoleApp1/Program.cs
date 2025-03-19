using System.Diagnostics.Metrics;
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

            //# Part2 Exercises-----------------------


            /*  while (true)
              {
                  Console.Clear();
                  Console.WriteLine("\nSelect a Program:");
                  Console.WriteLine("1. Simple Calculator");
                  Console.WriteLine("2. Basic ATM System");
                  Console.WriteLine("3. Geometry Calculator");
                  Console.WriteLine("4. Factorial of a Number");
                  Console.WriteLine("5. Sum of Even and Odd Numbers");
                  Console.WriteLine("6. Scientific Calculator");
                  Console.WriteLine("7. Print Triangle Pattern");
                  Console.WriteLine("8. Print Pyramid Pattern");
                  Console.WriteLine("9. Print Diamond Pattern");
                  Console.WriteLine("10. Guess the Number Game");
                  Console.WriteLine("0. Exit");
                  Console.Write("Enter your choice: ");
                  int choice = int.Parse(Console.ReadLine());

                  switch (choice)
                  {
                      case 1:
                          SimpleCalculato();
                          break;

                      case 2:
                          BasicATM();
                          break;
                      case 3:
                          GeometryCalculator();
                          break;
                      case 4:
                          Factorial();
                          break;
                      case 5:
                          evenodd();
                          break;
                      case 6:
                          ScientificCalculator();
                          break;
                      case 7:
                          PrintTriangle();
                          break;
                      case 8:
                          Pyramid();
                          break;
                      case 9:
                          Diamond();
                          break;
                      case 10:
                          GuessGame();
                          break;
                      case 0: return;
                      default: Console.WriteLine("Invalid Choice! Try again."); break;
                  }
                  Console.ReadLine();
              }




              //1.Simple Calculator(Switch - Case)
              static void SimpleCalculato()
              {
                  Console.WriteLine("Enter First Number:");
                  int num1 = int.Parse(Console.ReadLine());

                  Console.WriteLine("Enter second Number:");
                  int num2 = int.Parse(Console.ReadLine());
                  Console.WriteLine("Enter operator (+, -, *, /): ");
                  char op = Console.ReadKey().KeyChar;
                  //   Console.WriteLine();

                  double result = 0;
                  switch (op)
                  {
                      case '+':
                          result = num1 + num2;
                          Console.WriteLine("result is" + result);
                          break;

                      case '-':
                          result = num1 - num2;
                          Console.WriteLine("result is" + result);
                          break;

                      case '/':
                          result = num1 / num2;
                          Console.WriteLine("result is" + result);
                          break;
                      case '*':
                          result = num1 * num2;
                          Console.WriteLine("result is" + result);
                          break;

                      default:
                          Console.WriteLine("error");
                          break;

                  }
              }
              //---------------------------------------------------------------------------
              //2. Basic ATM System
              static void BasicATM()
              {


                  double balance = 1000;
                  while (true)
                  {
                      Console.WriteLine("\nATM Menu:");
                      Console.WriteLine("1. Withdraw");
                      Console.WriteLine("2. Deposit");
                      Console.WriteLine("3. Check Balance");
                      Console.WriteLine("4. Exit");
                      Console.Write("Enter your choice: ");
                      int choice = int.Parse(Console.ReadLine());
                      switch (choice)
                      {
                          case 1:
                              Console.Write("Enter withdrawal amount: ");
                              double withdraw = double.Parse(Console.ReadLine());
                              if (withdraw > balance) Console.WriteLine("Insufficient funds!");
                              else { balance -= withdraw; Console.WriteLine($"Withdrawal successful! New balance: {balance}"); }
                              break;
                          case 2:
                              Console.Write("Enter deposit amount: ");
                              double deposit = double.Parse(Console.ReadLine());
                              balance += deposit;
                              Console.WriteLine($"Deposit successful! New balance: {balance}");
                              break;
                          case 3:
                              Console.WriteLine($"Current Balance: {balance}");
                              break;
                          case 4:
                              return;
                          default:
                              Console.WriteLine("Invalid choice!");
                              break;
                      }


                  }
              }

              //--------------------------------------
              // 3. Geometry Calculator
              static void GeometryCalculator()
              {
                  Console.WriteLine("choose a shape :1.Circle,2.Square,3.Triangle");
                  char shape = char.Parse(Console.ReadLine());

                  switch (shape)
                  {
                      case '1':
                          Console.WriteLine("Enter the radius: ");
                          double radius = double.Parse(Console.ReadLine());
                          double area = radius * radius * Math.PI;
                          double cir = 2 + radius * Math.PI;
                          Console.WriteLine("area is : " + area + "Circumference is:" + cir);

                          break;

                      case '2':

                          Console.WriteLine("Enter the side length: ");
                          double length = double.Parse(Console.ReadLine());
                          double areasq = length * length;
                          double premeter = length * 4;
                          Console.WriteLine("area is : " + areasq + "perimeter  is:" + premeter);
                          break;
                      case '3':
                          Console.WriteLine("Enter the Length: ");
                          double Length = double.Parse(Console.ReadLine());
                          Console.WriteLine("Enter the base: ");
                          double baseLength = double.Parse(Console.ReadLine());
                          double trangleare = 0.5 * Length * baseLength;
                          Console.WriteLine("area is :" + trangleare);

                          break;
                      default:
                          Console.WriteLine("error");
                          break;
                  }
              }
              //-------------------------------------------------------
              // Factorial of a Number  
              static void Factorial()
              {
                  Console.WriteLine("Enter First Number:");
                  int num1 = int.Parse(Console.ReadLine());
                  float Factorial = 1;

                  for (int i = 1; i <= num1; i++)
                  {
                      Factorial *= i;
                  }
                  Console.WriteLine("Factorial is:" + Factorial);
              }

              //---------------------------------------------

              // 5.Sum of Even and Odd Numbers
              static void evenodd()
              {
                  Console.WriteLine("Enter Number:");


                  int num = int.Parse(Console.ReadLine());
                  int oddNum = 0;
                  int sumEven = 0;

                  for (int i = 1; i <= num; i++)
                  {
                      if (i % 2 == 0)
                      {
                          sumEven += i;
                      }
                      else
                          oddNum += i;
                      Console.WriteLine("sum of even Numbers:" + sumEven + "sum of odd Numbers:" + oddNum);
                  }
              }
              //-----------------------------------------
              // 6.Scientific Calculator(Switch - Case & Math Functions)
              static void ScientificCalculator()
              {

                  Console.WriteLine("choose  an operation :1.sin/2.cos/3.tan/4.sqrt/5.log/6.pow");
                  char op = char.Parse(Console.ReadLine());
                  double result = 0;
                  switch (op)
                  {
                      case '1':
                          Console.WriteLine("Enter a Number");
                          double Nsin = double.Parse(Console.ReadLine());
                          result = Math.Sin(Nsin);
                          Console.WriteLine(result);
                          break;

                      case '2':
                          Console.WriteLine("Enter a Number");
                          double Ncos = double.Parse(Console.ReadLine());
                          result = Math.Cos(Ncos);
                          Console.WriteLine(result);
                          break;

                      case '3':
                          Console.WriteLine("Enter a Number");
                          double Ntan = double.Parse(Console.ReadLine());
                          result = Math.Tan(Ntan);
                          Console.WriteLine(result);
                          break;

                      case '4':
                          Console.WriteLine("Enter a Number");
                          double Nsqrt = double.Parse(Console.ReadLine());
                          result = Math.Sqrt(Nsqrt);
                          Console.WriteLine(result);
                          break;

                      case '5':
                          Console.WriteLine("Enter a Number");
                          double Nlog = double.Parse(Console.ReadLine());
                          result = Math.Log(Nlog);
                          Console.WriteLine(result);
                          Console.WriteLine(result);
                          break;

                      case '6':
                          Console.WriteLine("Enter a Number");
                          double Npow = double.Parse(Console.ReadLine());
                          Console.WriteLine("Enter a Number");
                          double Npow1 = double.Parse(Console.ReadLine());
                          result = Math.Pow(Npow, Npow1);
                          Console.WriteLine(result);
                          break;


                      default:
                          Console.WriteLine("error");
                          break;
                  }

              }
              //-------------------------------------------------------------------------------------------
              //  7.Print Pattern(For Loop)
              static void PrintTriangle()
              {
                  Console.WriteLine("enter a number ");
                  int n = int.Parse(Console.ReadLine());
                  string x = "";
                  int i;

                  for (i = 1; i <= n; i++)
                  {

                      for (int j = 1; j <= i; j++)
                      {
                          x += "*";


                      }
                      Console.WriteLine(x);
                      x = "";

                  }
                  Console.WriteLine();
              }
              //-------------------------------------------

              //8. Print a Pyramid Pattern (For Loop)
              static void Pyramid()
              {
                  Console.WriteLine("enter a number ");
                  int n = int.Parse(Console.ReadLine());
                  string x = "";
                  int i;

                  for (i = 1; i < n; i++)
                  {

                      for (int j = 1; j < n - i - 1; j++)
                      {
                          // x += "*";
                          Console.Write(" ");

                          for (int k = 1; k < 2 * i + 1; k++)
                          {
                              Console.Write("*");
                          }


                      }
                      Console.WriteLine(x);
                      //x= "";

                  }
                  Console.WriteLine();
              }
              //----------------------------------
              //9. Print a Diamond Pattern (For Loop) 
              static void Diamond()
              {
                  Console.WriteLine("enter  number ");
                  int n = int.Parse(Console.ReadLine());


                  static void PrintDiamond()
                  {
                      Console.Write("Enter N: ");
                      int n = int.Parse(Console.ReadLine());

                      // Upper part of the diamond
                      for (int i = 1; i <= n; i++)
                      {
                          PrintRow(i, n);
                      }

                      // Lower part of the diamond
                      for (int i = n - 1; i >= 1; i--)
                      {
                          PrintRow(i, n);
                      }
                      //string x = "";
                      //int i;
                      //for (int i = 0; i < n; i++)
                      //{
                      //    for (int j = 0; j < n - i; j++)
                      //    {
                      //        Console.Write("");

                      //    }
                      //    for (int k = 0; k < 2 * i + 1; k++)
                      //    {
                      //        Console.Write("*");
                      //    }
                      //    Console.WriteLine();

                      //}

                      //for (int i = n - 1; i >= 0; i--)
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
                  }

              }


              //---------------------------------------------
              //10. Guess Game with helper 
              static void GuessGame()
              {
                  Random rand = new Random();
                  int target = rand.Next(1, 101);

                  int guess;

                  do
                  {
                      Console.Write("Guess the number (1-100): ");
                      guess = int.Parse(Console.ReadLine());


                      if (guess > target)
                          Console.WriteLine("Try Lower!");
                      else if (guess < target)
                          Console.WriteLine("Try Higher!");
                      else
                          Console.WriteLine("You Win!");


                  } while (guess != target);
              }


              */

            //------------------------C# Part3 Exercises -------------------------
            //1. Array Initialization & Output 
            // static void Array()
            //{
            //    Console.WriteLine("Array");
            //    int[] numbers = new int[5];
            //    numbers[0] = 8;
            //    numbers[1] = 10;
            //    numbers[2] = 12;
            //    numbers[3] = 14;
            //    numbers[4] = 16;


            //    for (int i = 0; i < numbers.Length; i++)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }



            //}
            //--------------------------------

            //2. Find Maximum & Minimum in an Array
            //Console.WriteLine("Enter 10 numbers:");
            //int[] numbers = new int[10];
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine($"Enter Number {i + 1}:");
            //    numbers[i] = int.Parse(Console.ReadLine());
            //}
            //int max = numbers[0];
            //int min = numbers[0];
            //for (int i = 1; i < numbers.Length; i++)
            //{
            //    if (numbers[i] > max)
            //    {
            //        max = numbers[i];
            //    }
            //    if (numbers[i] < min)
            //    {
            //        min = numbers[i];
            //    }
            //}
            //Console.WriteLine("Maximum:" + max);
            //Console.WriteLine("Minmum:" + min);
            //------------------------------------------------------
            //3.Count Even & Odd Numbers

            //Console.WriteLine("Enter Element numbers:");
            //int n = int.Parse(Console.ReadLine());

            //int[] numbers = new int[n];
            //Console.WriteLine("Enter numbers:");
            //for (int i = 0; i < n; i++)
            //{
            //    numbers[i] = int.Parse(Console.ReadLine());

            //}
            //int even = numbers.Count(num => num % 2 == 0);
            //int odd = numbers.Count(num => num % 2  != 0);

            //Console.WriteLine("even numbers " + even);
            //Console.WriteLine("even numbers " + odd);

            //----------------------------------
            // 4.Reverse an Array 
            //Console.WriteLine("Enter numbers:");
            //int n = int.Parse(Console.ReadLine());
            //int[] numbers = new int[n];
            //Console.WriteLine("Enter numbers:");
            //for (int i = 0; i < n; i++)
            //{

            //    numbers[i] = int.Parse(Console.ReadLine());

            //}
            //Console.WriteLine("OUTPUT is:" + numbers.Reverse());
            //Array.Reverse(numbers);
            //for (int i = 0; i < n; i++)
            //{

            //    Console.Write(numbers[i] + " ");

            //}

            //----------------------------------
            // 5.Search for a Number in an Array

            //    Console.WriteLine("Enter numbers:");
            //    int n = int.Parse(Console.ReadLine());
            //    int[] numbers = new int[n];
            //    Console.WriteLine("Enter numbers:");
            //    for (int i = 0; i < n; i++)
            //    {

            //        numbers[i] = int.Parse(Console.ReadLine());

            //    }
            //    Console.WriteLine("OUTPUT is:" + numbers.Reverse());
            //    Array.IndexOf(numbers, 2);
            //    for (int i = 0; i < n; i++)
            //    {

            //        Console.Write(numbers[i] + " ");

            //    }



            //}

            //------------------------------------------
            //6. Sorting an Array (Ascending Order)
            //    Console.WriteLine("Enter numbers:");
            //    int n = int.Parse(Console.ReadLine());
            //    int[] numbers = new int[n];
            //    Console.WriteLine("Enter numbers:");
            //    for (int i = 0; i < n; i++)
            //    {

            //        numbers[i] = int.Parse(Console.ReadLine());

            //    }
            //    // Console.WriteLine("OUTPUT is:" + numbers.sort());
            //    Array.Sort(numbers);
            //    for (int i = 0; i < n; i++)
            //    {

            //        Console.Write(numbers[i] + " ");

            //    }
            //}


            //------------------------------
            // Merging Two Arrays
            Console.WriteLine("Enter numbers:");
            int n = int.Parse(Console.ReadLine());

            int[] array1 = new int[n];
            int[] array2= new int[n];

            Console.WriteLine("enter Array 1:");
            for (int i =0;i<n;i++)
            {
                Console.WriteLine(" ");
                array1[i] = int.Parse(Console.ReadLine());
            }


            //static void PrintRow(int i, int n)
            //{

            //    for (int j = 0; j < n - i; j++)
            //        Console.Write(" ");

            //    for (int j = 0; j < 2 * i - 1; j++)
            //        Console.Write("*");

            //    Console.WriteLine();
            //}








        }
    }
}
    


    

 

    



