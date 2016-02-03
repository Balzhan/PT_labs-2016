using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prime
{
    class Program
    {
        static bool isPrime(int s)
        {
            //заводим переменную, чтобы считал количество делителей;
            int cnt = 0;
            //пробегаемся по массиву, от 2 до корня числа;
            //пробегаемся от 2, потому что каждое число имеет 2 делителя( делится на 1 и на само число);
            for (int j = 2; j <= Math.Sqrt(s); ++j)
            {
                //задаем условие, при котором число делится на j-тый элемент без остатка;
                if (s % j == 0)
                {
                    //если это условие выполняется, то прибавляем 1 к переменной;
                    cnt++;
                }
            }
            //возвращаем, начальное значение cnt, если число простое и не является 1; 
            return (cnt == 0) && (s != 1);
        }
        static void Main(string[] args)
        {
            //вводим числа;
            string enteredDigit = Console.ReadLine();
            //вводим числа в массив, через пробел;
            string[] enteredDigitArray = enteredDigit.Split(' ');
            //new char[] { ' ', ',', '.' }) также можно вводить числа, через запятую и точку, слэшы и т.д.;

            //заводим переменную длина массива, которая равна количеству элементов в массиве;
            int arrLength = enteredDigitArray.Length;
            //пробегаемся по массиву, от 0 до длины массива;
            for (int i = 0; i < arrLength; i++)
            {
                //заводим переменную, которая отвечает за i-тый элемент в массиве;
                string strElement = enteredDigitArray[i];
                //заводим переменную типа int, которая содержить в себе элементы со string-а;
                int enterSingle = Convert.ToInt32(strElement);
                //заводим переменную типа bool, и говорим что наша функция static bool верна;
                bool prime = isPrime(enterSingle);
                //задаем условие;
                if (prime)
                {
                    //если наш bool будет true, то выполняется следующее;
                    Console.WriteLine("the number " + enterSingle + " is prime");
                }
                else
                {
                    //в противном случае, введенное число является составным;
                    Console.WriteLine("the number " + enterSingle + " is not prime");
                }
            }
            //вводим данную строку, чтобы окно не закрывалось быстро;
            Console.ReadKey();
        }
    }
}
