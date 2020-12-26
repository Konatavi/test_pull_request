using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Lesson1
{
    /// <summary>
    /// программа нахождения суммы чисел
    /// </summary>
    class Program
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="filename"></param>
        /// <returns></returns>
        public static List<int> GetNumbersFromFile(string filename)
        {
            List<int> res = new List<int>();

            using (StreamReader file = new StreamReader(filename))
            {
                while (!file.EndOfStream)
                {
                    string line = file.ReadLine();
                    try
                    {
                        int n = Convert.ToInt32(line);
                        res.Add(n);
                    }
                    catch (Exception ex)
                    {

                    }
                }
            }

            return res;

        }

        public static void func_a()
        {

        }

        public static void some_new_feature_func_a()
        {

        }

        public static void feature2_function1()
        {
// some code

        }

        public static void feature2_function2()
        {
            //some code here
        }


        public void func_w()
        {

            int w = 0;
        }

        public void some_test_feature()
        {
            int s = "some code to merge & compare";

            int s3 = "some more code";


        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static List<int> GetNumbers()
        {
            List<int> res = new List<int>();

            string s;
            do
            {                
                s = Console.ReadLine();

                try
                {
                    int n = Convert.ToInt32(s);
                    res.Add(n);
                }
                catch (Exception ex)
                {

                }

            }
            while (s != "sum");

            return res;

        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static int InputNumber(string helpMsg)
        {
            Console.WriteLine(helpMsg);

            string s = Console.ReadLine();

            int n = Convert.ToInt32(s);

          

            return n;
        }


        /// <summary>
        /// ветка master - основная программа
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Вычисление суммы чисел");

            List<int> numbers = GetNumbers();
            
            Console.WriteLine($"Введено чисел: {numbers.Count}");

            int sum = (from a in numbers select a).Sum();

            Console.WriteLine($"Сумма чисел: {sum}");

            Console.WriteLine($"Проверка результата: {sum == InputNumber("Введите правильный ответ")}");

            Console.ReadLine();

        }
    }
}
