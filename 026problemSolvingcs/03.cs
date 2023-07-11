//((((((((((((((((1))))))))))))))))
//Write a C# program to check the sum of the two given integers. Return true if one of the integers is 20 or if their sum is 20.
//class a
//{
//    static void Main()
//    {
//        double n1, n2;
//        Console.WriteLine("enter first number");
//        n1=int.Parse(Console.ReadLine());  
//        Console.WriteLine("enter sec number");
//        n2=int.Parse(Console.ReadLine());  
//        Console.WriteLine(n1==20||n2==20||n1+n2==20?true:false);
//    }
//}
//((((((((((((((((2))))))))))))))))
//Write a C# program to check if the given integer is within 20 of 100 or 200.
//class a
//{
//    static void Main()
//    {
//        double n;
//        Console.WriteLine("enter your number");
//        n=int.Parse(Console.ReadLine());
//        Console.WriteLine(n-100<=20||n-200<=20?true:false);
//    }
//}
//((((((((((((((((3))))))))))))))))
//Write a C# program to convert a given string into lowercase.
//class a
//{
//    static void Main()
//    {
//        string str;
//        Console.WriteLine("enter your string");
//        str=Console.ReadLine();
//        Console.WriteLine(str.ToLower());
//    }
//}
//((((((((((((((((4))))))))))))))))
//Write a C# program to find the longest word in a string.
//class a
//{
//    static void Main()
//    {
//        string str;
//        Console.WriteLine("enter your string");
//        str=Console.ReadLine();
//        string[] strSplit = str.Split(new[] { " " } , StringSplitOptions.None);
//        string word = "";
//        int n = 0;
//        foreach (string str2 in strSplit)
//        {
//            if (str2.Length > n)
//            {
//                word= str2;
//                n= str2.Length;
//            }

//        }
//        Console.WriteLine(word);
//    }
//}
//((((((((((((((((5))))))))))))))))
//Write a C# program to print odd numbers from 1 to 99. Prints one number per line.
//class a
//{
//    static void Main()
//    {
//        double n;
//        for (int i = 1; i < 100; i+=2)
//        {
//            n = i;
//            Console.WriteLine(n);
//        }
//    }
//}
//((((((((((((((((6))))))))))))))))
//Write a C# program to compute the sum of the first 500 prime numbers.
//class a
//{
//    static void Main()
//    {
//        Console.WriteLine("the sum =");
//        int n = 2, ctr = 0, sum = 0;
//        while (ctr < 500)
//        {
//            if (isPrim(n))
//            {
//                sum += n;
//                ctr++;
//            }
//            n++;

//        }
//        Console.WriteLine(sum);
//    }
//    static bool isPrim(int n)
//    {
//        int x = (int)Math.Floor(Math.Sqrt(n));
//        if(n==1)return false;
//        if(n==2)return true;
//        for (int i = 2; i <= x; i++)
//        {
//            if (n % i == 0) return false;
//        }
//        return true;
//    }
//}
//((((((((((((((((7))))))))))))))))
//Write a C# program and compute the sum of an integer's digits.
//class a
//{
//    static void Main()
//    {
//        int n=0,sum=0;
//        Console.WriteLine("enter number");
//        n = int.Parse(Console.ReadLine());
//        while (n != 0)
//        {
//            sum += n % 10;
//            n /= 10;
//        }
//        Console.WriteLine("sum={0}",sum);
//    }
//}
//((((((((((((((((8))))))))))))))))
//Write a C# program to reverse the words of a sentence.
//class a
//{
//    static void Main()
//    {
//        string str = "mostafa mohamed taha";
//        string[] strArr=str.Split(' ');
//        string newStr = "";
//        for (int i = strArr.Length-1; i >=0 ; i--)
//        {
//            newStr += strArr[i]+" ";
//        }
//        Console.WriteLine(newStr);
//    }
//}
//((((((((((((((((9))))))))))))))))
//Write a C# program to find the size of a specified file in bytes.
//using System.IO;

//class a
//{
//    static void Main()
//    {
//        FileInfo a = new FileInfo("C:/Users/mostafa/Desktop/text.txt");
//        Console.WriteLine(a.Length.ToString());
//    }
//}
//((((((((((((((((10))))))))))))))))
//Write a C# program to convert a hexadecimal number to a decimal number.
//using System;
//using System.Collections.Generic;
//class a
//{
//    static void Main()
//    {
//        string str = "4b0";
//        Console.WriteLine(int.Parse(str,System.Globalization.NumberStyles.HexNumber)); 
//    }
//}