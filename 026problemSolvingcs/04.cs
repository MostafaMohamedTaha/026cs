using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace _026problemSolvingcs
{
    //((((((((((((((((1))))))))))))))))
    //Write a C# program to multiply the corresponding elements of two integer arrays.
    //class a
    //{
    //    static void Main()
    //    {
    //        int[] arr1 = { 1, 2, 3, 4 };
    //        int[] arr2 = { 1, 2, 3, 4 };
    //        for (int i = 0; i < arr1.Length; i++)
    //        {
    //            Console.WriteLine(arr1[i] * arr2[i]);
    //        }
    //    }
    //}

    //((((((((((((((((2))))))))))))))))
    //Write a C# program to create a string of four copies, taking the last four characters from a given string. If the given string is less than 4, return the original one.
    //class a
    //{
    //    static void Main()
    //    {
    //        string str = "mostafa";
    //        Console.WriteLine(str.Length >= 4 ? str.Substring(3) : str);
    //    }
    //}
    //((((((((((((((((3))))))))))))))))
    //Write a C# program to check if a given positive number is a multiple of 3 or 7.
    //class a
    //{
    //    static void Main()
    //    {
    //        int n;
    //        Console.WriteLine("enter number");
    //        n = int.Parse(Console.ReadLine());
    //        Console.WriteLine(n%3 == 0 || n%7 ==0?true:false);
    //    }
    //}
    //((((((((((((((((4))))))))))))))))
    //Write a C# program to check if a string starts with a specified word.
    //Note: Suppose the sentence starts with "Hello"
    //Sample Data: string1 = "Hello how are you?"
    //Result: Hello.
    //class a
    //{
    //    static void Main()
    //    {
    //        string str = "hello how are you";
    //        Console.WriteLine(str.StartsWith("hello")?true:false);
    //    }
    //}
    //((((((((((((((((5))))))))))))))))
    //Write a C# program to check two given numbers where one is less than 100 and the other is greater than 200.
    //class a
    //{
    //    static void Main()
    //    {
    //        double n1=0, n2=0;
    //        Console.WriteLine("enter n1");
    //        n1 = int.Parse(Console.ReadLine());
    //        Console.WriteLine("enter n2");
    //        n2 = int.Parse(Console.ReadLine());
    //        Console.WriteLine(n1>200&&n2<100||n1<100&&n2>200?true:false);
    //    }
    //}
    //((((((((((((((((6))))))))))))))))
    //Write a C# program to check if an integer (from the two given integers) is in the range -10 to 10.
    //class a
    //{
    //    static void Main()
    //    {
    //        double n1 = 0, n2 = 0;
    //        Console.WriteLine("enter n1");
    //        n1 = Convert.ToInt32(Console.ReadLine());
    //        Console.WriteLine("enter n2");
    //        n2 = Convert.ToInt32(Console.ReadLine());
    //        Console.WriteLine(n1 > -10 && n1 < 10 && n2 < 10 && n2 > -10 ? true : false);
    //    }
    //}
    //((((((((((((((((7))))))))))))))))
    //Write a C# program to check if "HP" appears at the second position in a string and return the string without "HP".
    //class a
    //{
    //    static void Main()
    //    {
    //        string str = "php is puple";
    //        Console.WriteLine(str.Substring(1,2)=="hp"?str.Remove(1,2):str);
    //    }
    //}
    //((((((((((((((((8))))))))))))))))
    //Write a C# program to get a string of two characters from a given string. The first and second characters of the given string must be "P" and "H", so PHP will be "PH".
    //class a
    //{
    //    static void Main()
    //    {
    //        string str = "php from class a";
    //        Console.WriteLine(str.Substring(0,2)=="ph"? str.Substring(0, 2):str); 
    //    }
    //}
    //((((((((((((((((9))))))))))))))))
    //Write a C# program to find the largest and lowest values from three integer values.
    //class a
    //{
    //    static void Main()
    //    {
    //        int n1=1,n2=2,n3=3,max,min;
    //        max=Math.Max(n1,Math.Max(n2,n3));
    //        min = Math.Min(n1, Math.Min(n2, n3));
    //        Console.WriteLine("max value ={0} , min value={1}",max,min);
    //    }
    //}
    //((((((((((((((((10))))))))))))))))
    //Write a C# program that checks the nearest value of 20 of two given integers and return 0 if two numbers are same.
    //class a
    //{
    //    static void Main()
    //    {
    //        int n1 = 10, n2 = 40,n1v,n2v;
    //        n1v = Math.Abs(n1 - 20);
    //        n2v = Math.Abs(n2 - 20);
    //        Console.WriteLine(n1v > n2v ? n2: n1);
    //    }
    //}
}
