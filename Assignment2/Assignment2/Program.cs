/*
Program: Assignment2
Programmer: Felipe SG
Date: 24/01/2021
Objective: 
_________________________________________________________________________________________________________________
1-) Write a program that prints on the console the numbers from 1 to N. 
The number N should be read from the standard input.
  
2-) Write a program that prints on the console the numbers from 1 to N, 
which are not divisible by 3 and 7 simultaneously. The number N should be read from the standard input.
  
3-) Write a program that reads from the console a series of integers and prints the smallest and largest of them.
  
1-) Write a program, which creates an array of 20 elements of type integer and initializes each of the elements 
with a value equals to the index of the element multiplied by 5. Print the elements to the console.

4-) Write a program, which finds the maximal sequence of consecutive equal elements in an array. 
E.g.: {1, 1, 2, 3, 2, 2, 2, 1}  {2, 2, 2}.

5-) Write a program, which finds the maximal sequence of consecutively placed increasing integers. 
Example: {3, 2, 3, 4, 2, 2, 4}  {2, 3, 4}.

1-) Write a code that by given name prints on the console "Hello, <name>!" (for example: "Hello, Peter!").

2-) Create a method GetMax() with two integer (int) parameters, that returns maximal of the two numbers. 
Write a program that reads three numbers from the console and prints the biggest of them. Use the GetMax() 
method you just created. Write a test program that validates that the methods works correctly.

4-) Write a method that finds how many times certain number can be found in a given array. Write a program 
to test that the method works correctly.
_________________________________________________________________________________________________________________

*/

using System;

namespace Assignment2
{
    class Program
    {
        int zero=0, one=0, two=0, three=0, four=0, five=0, six=0, seven=0, eight=0, nine=0;
        public void Ex1()
        {
            Console.WriteLine("Write a program that prints on the console the numbers from 1 to N. ");
            Console.WriteLine("The number N should be read from the standard input ");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Please type a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int target = number;
  
            for (int n = 0; n <= number; n++)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine("Press any key to go back to main menu");
            Console.ReadLine();
            ShowMenu();
        }
        public void Ex2()
        {
            Console.WriteLine("Write a program that prints on the console the numbers from 1 to N");
            Console.WriteLine("which are not divisible by 3 and 7 simultaneously. The number N should be read from the standard input");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Please type a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int target = number;

            for (int n = 0; n <= target; n++)
            {
                if (n % 3 == 0 && n % 7 == 0) 
                {
                   
                }
                else
                {
                    Console.WriteLine(n);
                }
            }
            Console.WriteLine("Press any key to go back to main menu");
            Console.ReadLine();
            ShowMenu();
        }
        public void Ex3()
        {
            Console.WriteLine("Write a program that reads from the console a series of integers and prints the smallest and largest of them");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Please type number 1: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int target = number;
            Console.WriteLine("Please type number 2: ");
            int number2 = Convert.ToInt32(Console.ReadLine());
            int targer2 = number2;
            Console.WriteLine("Please type number 3: ");
            int number3 = Convert.ToInt32(Console.ReadLine());
            int targer3 = number3;

            if (number > number2 && number > number3)
            {
                Console.WriteLine("The first number is greater: {0}", number);
            }
            if (number < number2 && number < number3)
            {
                Console.WriteLine("The first number is the smallest: {0}", number);
            }
            if (number2 > number && number2 > number3)
            {
                Console.WriteLine("The seccond number is greater: {0}", number2);
            }
            if (number2 < number && number2 < number3)
            {
                Console.WriteLine("The seccond number is smallest: {0}", number2);
            }
            if (number3 > number && number3 > number2)
            {
                Console.WriteLine("The third number is greater: {0}", number3);
            }
            if (number3 < number && number3 < number2)
            {
                Console.WriteLine("The third number is smallest: {0}", number3);
            }

            Console.WriteLine("Press any key to go back to main menu");
            Console.ReadLine();
            ShowMenu();
        }      
        public void Ex4()
        {
            Console.WriteLine("Write a program, which creates an array of 20 elements of type integer and initializes each of the elements");
            Console.WriteLine("with a value equals to the index of the element multiplied by 5.Print the elements to the console");
            Console.WriteLine("--------------------------------------------");

            int[] arrayTest = new int[20];
            for (int i=0; i < arrayTest.Length; i++)
            {
                int temp = i * 5;
                arrayTest[i] = temp;
                Console.WriteLine("{0}", arrayTest[i]);
            }

            Console.WriteLine("Press any key to go back to main menu");
            Console.ReadLine();
            ShowMenu();

        }
        public void Ex5()
        {
            Console.WriteLine("  Write a program, which finds the maximal sequence of consecutive equal elements in an array.");
            Console.WriteLine("  E.g.: { 1, 1, 2, 3, 2, 2, 2, 1}  { 2, 2, 2}.");
            Console.WriteLine("--------------------------------------------");

            int[] arrayTest = new int[8] { 1, 1, 2, 3, 2, 2, 2, 1 };
            int[] arrayTest2 = new int[3];
            int counter=0;
            for (int i = 0; i < arrayTest.Length; i++)
            {
                int next = i + 1;
                if (arrayTest.Length > next)
                {
                    if (arrayTest[i] == arrayTest[next])
                    {
                        arrayTest2[counter] = arrayTest[i];
                        counter++;
                    }
                    if (i != 0)
                    {
                        if (arrayTest[i] == arrayTest[i - 1])
                        {
                            arrayTest2[counter] = arrayTest[i];
                            counter++;
                        }
                        if (arrayTest[i] != arrayTest[i - 1])
                        {
                            counter = 0;
                        }
                    }
                }              
            }
            for (int i = 0; i < arrayTest2.Length; i++)
            {
                Console.WriteLine("{0}", arrayTest2[i]);
            }
            Console.WriteLine("Press any key to go back to main menu");
            Console.ReadLine();
            ShowMenu();
        }
        public void Ex6()
        {
            Console.WriteLine("Write a program, which finds the maximal sequence of consecutively placed increasing integers. ");
            Console.WriteLine("Example: {3, 2, 3, 4, 2, 2, 4}  {2, 3, 4}");
            Console.WriteLine("--------------------------------------------");

            int[] arrayTest = new int[7] { 3, 2, 3, 4, 2, 2, 4 };
            int[] arrayTest2 = new int[3];
            int counter = 0;
            for (int i = 0; i < arrayTest.Length; i++)
            {
                int next = i + 1;
                if (arrayTest.Length > next)
                {
                    if (arrayTest[i] < arrayTest[next])
                    {
                        arrayTest2[counter] = arrayTest[i];
                        counter++;
                    }
                    if (i != 0)
                    {
                        if (arrayTest[i] > arrayTest[i - 1])
                        {
                            arrayTest2[counter] = arrayTest[i];
                            counter++;
                        }
                        if (arrayTest[i] < arrayTest[i - 1])
                        {
                            counter = 0;
                        }
                    }
                }
            }
            for (int i = 0; i < arrayTest2.Length; i++)
            {
                Console.WriteLine("{0}", arrayTest2[i]);
            }
            Console.WriteLine("Press any key to go back to main menu");
            Console.ReadLine();
            ShowMenu();
        }
        public void Ex7()
        {
            Console.WriteLine("Write a code that by given name prints on the console Hello, < name > ! For example: Hello, Peter!).");
            Console.WriteLine("--------------------------------------------");
            string fName = name();
            Console.WriteLine("Hello {0}", fName);
            Console.WriteLine("Press any key to go back to main menu");
            Console.ReadLine();
            ShowMenu();
        }
        public string name()
        {
            string name;
            Console.WriteLine("Please inform your name: ");
            name = Console.ReadLine();
            return name;
        }
        public void Ex8()
        {
            Console.WriteLine("Create a method GetMax() with two integer (int) parameters, that returns maximal of the two number");
            Console.WriteLine("Write a program that reads three numbers from the console and prints the biggest of them. Use the GetMax() ");
            Console.WriteLine("method you just created. Write a test program that validates that the methods works correctly.");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Please inform the first number: ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please inform the 2nd number: ");
            int number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The max Number is: {0}",GetMax(number1, number2));
            Console.WriteLine("Press any key to go back to main menu");
            Console.ReadLine();
            ShowMenu();
        }
        public int GetMax(int a, int b)
        {
            int max = 0;
            if (a > b)
            {
                max = a;
            }
            if (a == b)
            {
                max = a;
            }
            if (b > a)
            {
                max = b;
            }     

            return max;
        }
        public void Ex9()
        {
            Console.WriteLine("Write a method that finds how many times certain number can be found in a given array.");
            Console.WriteLine("Write a program to test that the method works correctly.");
            Console.WriteLine("--------------------------------------------");
            int[] arrayTest = new int[5] { 2, 2, 2, 3, 4 };
            for (int i = 0; i < arrayTest.Length; i++)
            {
                CheckValues(arrayTest[i]);
            }

            Console.WriteLine("[{0}]", string.Join(", ", arrayTest));
            Console.WriteLine("The number zero appeared: {0} time(s)", zero);
            Console.WriteLine("The number one appeared: {0} time(s)", one);
            Console.WriteLine("The number two appeared: {0} time(s)", two);
            Console.WriteLine("The number three appeared: {0} time(s)", three);
            Console.WriteLine("The number four appeared: {0} time(s)", four);
            Console.WriteLine("The number five appeared: {0} time(s)", five);
            Console.WriteLine("The number six appeared: {0} time(s)", six);
            Console.WriteLine("The number seven appeared: {0} time(s)", seven);
            Console.WriteLine("The number eight appeared: {0} time(s)", eight);
            Console.WriteLine("The number nine appeared: {0} time(s)", nine);
            Console.WriteLine("Press any key to go back to main menu");
            Console.ReadLine();
            ShowMenu();
        }
        public int CheckValues(int i)
        {
            switch (i)
            {
                case 0:
                    zero++;
                    break;
                case 1:
                    one++;
                    break;
                case 2:
                    two++;
                    break;
                case 3:
                    three++;
                    break;
                case 4:
                    four++;
                    break;
                case 5:
                    five++;
                    break;
                case 6:
                    six++;
                    break;
                case 7:
                    seven++;
                    break;
                case 8:
                    eight++;
                    break;
                case 9:
                    nine++;
                    break;

                default:
                    Console.WriteLine("Default case");
                    break;
            }

            return 0;
        }
        public void ShowMenu()
        {
            Console.Clear();
            Console.WriteLine("Welcome to assingment 2");
            Console.WriteLine("----------------");
            Console.WriteLine("1 - Cap 6 Part 1");
            Console.WriteLine("2 - Cap 6 Part 2");
            Console.WriteLine("3 - Cap 6 Part 3");
            Console.WriteLine("----------------");
            Console.WriteLine("4 - Cap 7 Part 1");
            Console.WriteLine("5 - Cap 7 Part 2");
            Console.WriteLine("6 - Cap 7 Part 3");
            Console.WriteLine("----------------");
            Console.WriteLine("7 - Cap 9 Part 1");
            Console.WriteLine("8 - Cap 9 Part 2");
            Console.WriteLine("9 - Cap 9 Part 3");
            Console.WriteLine("----------------");
            Console.WriteLine("0 - EXIT");
            int menuOption = Convert.ToInt32(Console.ReadLine());
            Program program = new Program();
            switch (menuOption)
            {
                case 0:
                    System.Environment.Exit(1);
                    break;
                case 1:
                    program = new Program();
                    program.Ex1();
                    break;
                case 2:
                    program = new Program();
                    program.Ex2();  
                    break;
                case 3:
                    program = new Program();
                    program.Ex3();
                    break;
                case 4:
                    program = new Program();
                    program.Ex4();
                    break;
                case 5:
                    program = new Program();
                    program.Ex5();
                    break;
                case 6:
                    program = new Program();
                    program.Ex6();
                    break;
                case 7:
                    program = new Program();
                    program.Ex7();
                    break;
                case 8:
                    program = new Program();
                    program.Ex8();
                    break;
                case 9:
                    program = new Program();
                    program.Ex9();
                    break;
                default:
                    Console.WriteLine("Default case");
                    break;

            }
        }
        static void Main(string[] args)
        {
            Program program = new Program();
            program.ShowMenu();
        }
    }
}
