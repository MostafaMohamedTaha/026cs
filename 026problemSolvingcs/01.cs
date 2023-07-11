using System;
//((((((((((((((((((((1))))))))))))))))))))
//public class a
//{
//    public static void Main()
//    {
//        Console.WriteLine("hello");
//        Console.WriteLine("mostafa");
//        Console.WriteLine(12 + 18);
//    }
//}
//((((((((((((((((((((3))))))))))))))))))))
//public class a
//{
//    public static void Main()
//    {
//        Console.WriteLine(36/6);
//    }
//}

//((((((((((((((((((((4))))))))))))))))))))
//public class a
//{
//    public static void Main()
//    {
//        Console.WriteLine(-1+4*6);
//        Console.WriteLine((35+5)%7);
//        Console.WriteLine(14+-4*6/11);
//        Console.WriteLine(2+15/6*1-7%2);
//    }
//}
//((((((((((((((((((((5))))))))))))))))))))
//The act of swapping two variables refers to mutually exchanging the values of the variables. Generall, this is done with the data in memory.
//class a
//{
//    static void Main(string[] args)
//    {
//        double n1, n2, temp;
//        Console.WriteLine("enter first number");
//        n1 = int.Parse(Console.ReadLine());
//        Console.WriteLine("enter second number");
//        n2 = int.Parse(Console.ReadLine());
//        temp = n1;
//        n1 = n2;
//        n2 = temp;
//        Console.WriteLine("swap n1={0} , n2={1}",n1,n2);
//    }

//}
//((((((((((((((((((((6))))))))))))))))))))
//public class a
//{
//   public static void Main(string[] args)
//    {
//        double n1, n2, n3, result;
//        Console.WriteLine("enter first number");
//        n1=int.Parse(Console.ReadLine());
//        Console.WriteLine("enter second number");
//        n2=int.Parse(Console.ReadLine());
//        Console.WriteLine("enter third number");
//        n3=int.Parse(Console.ReadLine());
//        result = n1 * n2 * n3;
//        Console.WriteLine("result = {0} * {1} * {2} = {3}" ,n1,n2,n3,result) ;

//    }
//}
//((((((((((((((((((((7))))))))))))))))))))
//Write a C# Sharp program to print on screen the output of adding, subtracting, multiplying and dividing two numbers entered by the user.
//class a
//{
//    static void Main()
//    {
//        double n1, n2;
//        Console.WriteLine("enter first number");
//        n1 = int.Parse(Console.ReadLine());
//        Console.WriteLine("enter second number");
//        n2 = int.Parse(Console.ReadLine());
//        Console.WriteLine("sum={0}+{1}={2}", n1, n2, n1 + n2);
//        Console.WriteLine("sub={0}-{1}={2}", n1, n2, n1 - n2);
//        Console.WriteLine("multi={0}*{1}={2}", n1, n2, n1 * n2);
//        Console.WriteLine("div={0}/{1}={2}", n1, n2, n1 / n2);
//    }
//}
//((((((((((((((((((((7))))))))))))))))))))
//Write a C# Sharp program that prints the multiplication table of a number as input.

//In mathematics, a multiplication table is a mathematical table used to define a multiplication operation for an algebraic system.
//class a
//{
//    static void Main()
//    {
//        double n1;
//        Console.WriteLine("enter your number");
//        n1=int.Parse(Console.ReadLine());
//        for(int i = 1; i <= 10; i++) {
//            Console.WriteLine("{0}*{1}={2}",n1,i,n1*i);
//        }
//    }
//}
//((((((((((((((((((((9))))))))))))))))))))
//Write a C# Sharp program that takes four numbers as input to calculate and print the average.

//class a
//{
//   static void Main()
//    {
//        double n1,n2,n3,n4;
//        Console.WriteLine("enter your first number");
//        n1=int.Parse(Console.ReadLine());
//        Console.WriteLine("enter your sec number");
//        n2=int.Parse(Console.ReadLine());
//        Console.WriteLine("enter your third number");
//        n3=int.Parse(Console.ReadLine());
//        Console.WriteLine("enter your fourth number");
//        n4=int.Parse(Console.ReadLine());
//        Console.WriteLine("average ={0}",(n1+n2+n3+n4)/4);
//    }
//}
//((((((((((((((((((((10))))))))))))))))))))
//Write a C# Sharp program that takes three numbers (x,y,z) as input and outputs (x+y).z and x.y + y.z.
//class a
//{
//    static void Main()
//    {
//        double n1, n2,n3;
//        Console.WriteLine("enter first nubmer");
//        n1=int.Parse(Console.ReadLine());
//        Console.WriteLine("enter sec nubmer");
//        n2=int.Parse(Console.ReadLine());
//        Console.WriteLine("enter third nubmer");
//        n3=int.Parse(Console.ReadLine());
//        Console.WriteLine("result=(n1+n2) *n3={0}",(n1+n2)*n3);
//        Console.WriteLine("result=(n1*n2)+(n2*n3)={0}",(n1*n2)+n2*n3);
//    }
//}