using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23
{
    internal class Program
    {
        delegate bool Funcsiya_1(int x);
        delegate int Funcsiya_2(int x);
        delegate int Funcsiya_3(int x);
        delegate bool Funcsiya_4(int x);
        delegate int Funcsiya_5(int[] x);
        delegate int Funcsiya_6(int[] x);
        delegate void Funcsiya_7(int[] x);
        static void Main(string[] args)
        {
            #region Первая задача

            Funcsiya_1 funcsiya_1 = delegate (int x)
            {
                return (x % 2 == 0 && x != 0);
            };
            Console.WriteLine(funcsiya_1(2));
            #endregion

            #region Вторая задача 

            Funcsiya_2 funcsiya_2 = delegate (int x)
            {
                return x * x;
            };
            Console.WriteLine(funcsiya_2(2));
            #endregion

            #region Третья задача 

            Funcsiya_3 funcsiya_3 = x => x * x * x;
            Console.WriteLine(funcsiya_3(2));
            #endregion

            #region Четвертая задача

            Funcsiya_4 funcsiya_4 = x => x == 256;
            Console.WriteLine(funcsiya_4(256));
            #endregion

            #region Пятая задача

            int[] arr = { 10, 2, 3, 4, 5, 6, 7, 8, 9 };
            Funcsiya_5 funcsiya_5 = (int[] x) =>
            {
                int bufer = arr[0];
                for (int i = 0; i < x.Length; i++)
                    if (bufer < arr[i])
                        bufer = arr[i];
                return bufer;
            };
            Console.WriteLine(funcsiya_5(arr));
            #endregion

            #region Шестая задача 

            Funcsiya_6 funcsiya_6 = (int[] x) =>
            {
                int bufer = arr[0];
                for (int i = 0; i < x.Length; i++)
                    if (bufer > arr[i])
                        bufer = arr[i];
                return bufer;
            };
            Console.WriteLine(funcsiya_6(arr));
            #endregion

            #region Седьмая задача

            Funcsiya_7 funcsiya_7 = (int[] x) =>
            {
                for (int i = 0; i < x.Length; i++)
                    if (x[i] % 2 != 0)
                        Console.Write(x[i] + " ");
                Console.WriteLine();
            };
            funcsiya_7(arr);
            #endregion
        }
    }
}
