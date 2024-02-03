//решение задачи 1
//using System;

//class Program
//{
 //   static void PrintNaturalNumbers(int m, int n)
   // {
    //    if (m <= n)
     //   {
       //     Console.WriteLine(m);
         //   PrintNaturalNumbers(m + 1, n);
        //}
    //}

    //static void Main()
    //{
      //          int M = 1;
        //int N = 10;

        
              // PrintNaturalNumbers(M, N);
   // }
//}

//решение задачи 2

using System;

//class Program
//{
   // static void Main()
    //{
        // Пример вызова функции Аккермана с m=2 и n=3
  //      int result = AckermannFunction(2, 3);
    //    Console.WriteLine($"Ackermann(2, 3) = {result}");
    //}

    //static int AckermannFunction(int m, int n)
    //{
     //   if (m == 0)
      //  {
       //     return n + 1;
        //}
        //else if (n == 0)
        //{
         //   return AckermannFunction(m - 1, 1);
        //}
        //else
        //{
         //   return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
        //}
    //}
//}

//решение задачи 3

using System;

class Program
{
    static void Main()
    {
        // Пример массива
        int[] myArray = { 1, 2, 3, 4, 5 };

        // Вызов функции для вывода элементов с конца
        PrintArrayReverse(myArray, myArray.Length - 1);
    }

    static void PrintArrayReverse(int[] arr, int index)
    {
        if (index >= 0)
        {
            Console.WriteLine(arr[index]);
            PrintArrayReverse(arr, index - 1);
        }
    }
}