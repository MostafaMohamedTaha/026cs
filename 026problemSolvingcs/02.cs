using System;
//(((((((((((((((1)))))))))))))))
//Write a C# Sharp program that takes an age (for example 20) as input and prints something like "You look older than 20".
//class a
//{
//    static void Main()
//    {
//        double age;
//        Console.WriteLine("enter your age");
//        age=int.Parse(Console.ReadLine());
//        Console.WriteLine("your age is {0}",age);
//    }
//}
//(((((((((((((((2)))))))))))))))
//Write a C# program that takes a number as input and displays it four times in a row (separated by blank spaces), and then four times in the next row, with no separation. You should do it twice: Use the console. Write and use {0}.
//class a
//{
//    static void Main()
//    {
//        double n;
//        Console.WriteLine("enter your number");
//        n=int.Parse(Console.ReadLine());
//        for (int i = 0; i < 2; i++)
//        {
//            Console.WriteLine("{0} {1} {2} {3}",n,n,n,n);
//            Console.WriteLine("{0}{1}{2}{3}",n,n,n,n);
//        }
//    }
//}
//(((((((((((((((3)))))))))))))))
//Write a C# program that takes a number as input and displays a rectangle of 3 columns wide and 5 rows tall using that digit.
//class a
//{
//    static void Main()
//    {
//        int n;
//        Console.WriteLine("enter your number");
//        n=int.Parse(Console.ReadLine());
//        Console.WriteLine("{0}{1}{2}",n,n,n);
//        Console.WriteLine("{0} {1}",n,n);
//        Console.WriteLine("{0} {1}",n,n);
//        Console.WriteLine("{0} {1}",n,n);
//        Console.WriteLine("{0}{1}{2}",n,n,n);
//    }
//}
//(((((((((((((((4)))))))))))))))
//Write a C# program to convert Celsius degrees to Kelvin and Fahrenheit.
//kelvin = celsius + 273
//fahrenheit = celsius x 18 / 10 + 32
//class a
//{
//    static void Main()
//    {
//        Console.WriteLine("enter your celsius degree");
//        double cel = 0;
//        cel=int.Parse(Console.ReadLine());
//        Console.WriteLine("cel to kelvin = {0}",cel+273);
//        Console.WriteLine("cel to fehrenheit = {0}",(cel*18/10)+32);
//    }
//}
//(((((((((((((((5)))))))))))))))
//Write a C# program that removes a specified character from a non-empty string using the index of a character.
//class a
//{
//    static void Main()
//    {
//        Console.WriteLine(rmChar("mostafa",1));
//        Console.WriteLine(rmChar("mostafa",2));
//        Console.WriteLine(rmChar("mostafa",3));
//    }
//    static string rmChar(string str,int n)
//    {
//        return str.Remove(n,1);
//    }
//}
//(((((((((((((((6)))))))))))))))
//Write a C# program to create a new string from a given string where the first and last characters change their positions.
//class a
//{
//    static void Main()
//    {
//        Console.WriteLine(swap("mostafa"));
//    }
//    static string swap(string str)
//    {
//        return str.Length > 1
//            ? str.Substring(str.Length - 1) + str.Substring(1, str.Length - 2) + str.Substring(0, 1)
//            : str;
//    }
//}
//(((((((((((((((7)))))))))))))))
//Write a C# program to create a string from a given string (length 1 or more) with the first character added at the front and back.
//class a
//{
//    static void Main()
//    {
//        Console.WriteLine(add("mostafa"));
//    }
//    static string add(string str)
//    {
//        return str.Length > 1
//            ? str.Substring(0, 1) + str + str.Substring(0, 1)
//            : str;
//    }
//}


//(((((((((((((((8)))))))))))))))
//Write a C# program to check a pair of integers and return true if one is negative and one is positive.
//class a
//{
//    static void Main()
//    {
//        double n1, n2;
//        Console.WriteLine("enter first number");
//        n1=int.Parse(Console.ReadLine());
//        Console.WriteLine("enter second number");
//        n2=int.Parse(Console.ReadLine());
//        Console.WriteLine(n1 > 0 && n2 < 0 || n1 < 0 && n2 > 0 ? true : false);
//    }
//}
//(((((((((((((((9)))))))))))))))
//Write a C# program to compute the sum of two given integers. If two values are the same, return the triple of their sum.
//class a
//{
//    static void Main()
//    {
//        double n1, n2;
//        Console.WriteLine("enter first number");
//        n1=int.Parse(Console.ReadLine());
//        Console.WriteLine("enter second number");
//        n2=int.Parse(Console.ReadLine());
//        Console.WriteLine(n1==n2?(n1+n2)*3:n1+n2);
//    }
//}
//(((((((((((((((10)))))))))))))))
//Write a C# program to get the absolute value of the difference between two given numbers. Return double the absolute value of the difference if the first number is greater than the second number.
//class a
//{
//    static void Main()
//    {
//        Console.WriteLine(abs(13,40));
//    }
//    static double abs(double n1,double n2)
//    {
//        return n1 > n2
//            ? (n1 - n2) * 2
//            : n2 - n1;
//    }
//}