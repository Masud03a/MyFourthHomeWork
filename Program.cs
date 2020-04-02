using System;

namespace MyFourthConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
                            //д/з-----------------------------------------------------------------------------
            Console.WriteLine("Задания 2");
            Console.WriteLine("Введите сумму покупок");
            double n,b;
            n=Convert.ToInt32(Console.ReadLine());
            if(n>500 && n<=1000)
            {
                b=n-n*3/100 ;
                Console.WriteLine("///////////////");
                Console.WriteLine($"ваша покупка c учетом скидки составляет {b} Сомони ") ;
            }
            if(n<=500)
            {
                Console.WriteLine("///////////////");
                Console.WriteLine($"На эту сумму покупок скидки нету");
            }
            if(n>1000)
            {
                b=n-n*5/1000;
                Console.WriteLine("///////////////");
                Console.WriteLine($"ваша покупка c учетом скидки составляет {b} Сомони ") ;
            }


            /////////////////N-3
            Console.WriteLine("Задания 3");

            int a1,b1,c1,d1;
            Console.WriteLine("Введите первый элемент последовательности");
            a1=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите второй  элемент последовательности");
            b1=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите треттй элемент последовательности");
            c1=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите четвертый элемент последовательности");
            d1=Convert.ToInt32(Console.ReadLine());         

            if(a1<b1 && b1<c1 && c1<d1)
            {
                Console.WriteLine("///////////////");
                Console.WriteLine("Числа расположены по возрастанию");

            }
            else 
            {
                if(a1==b1 && b1==c1 && c1==d1)
                {
                Console.WriteLine("///////////////");
                Console.WriteLine(a1*b1*c1*d1);
                }
                else 
                {

                    Console.WriteLine("///////////////");
                    int min1=Math.Min(Math.Min(a1,b1),Math.Min(c1,d1));
                    Console.WriteLine(min1);


                }
            }
            ////////////N-4
            int a11,a12,a13,s;
            Console.WriteLine("Задания 4");

            Console.WriteLine("Введите первый число");
            a11=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите второй число");
            a12=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите третий число");
            a13=Convert.ToInt32(Console.ReadLine());

            int  max11=Math.Max(Math.Max(a11,a12),a13),min11=Math.Min(Math.Min(a11,a12),a13);
            s=a11+a12+a13;
            a11=max11;
            a12=s-max11-min11;
            a13=min11;
            Console.WriteLine("///////////////");
            Console.WriteLine($"{a11},{a12},{a13}");
            }
        }
    }
}
