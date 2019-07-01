using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkWithString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Тестовые задания";

            //task_1
            int num_1 = 3456;
            Console.WriteLine("\nTask_1: ( Переданое число: " + num_1 + " ), Результат:" + Reverse_One(num_1) +"\n");

            //task_2
            int num_2 = 9375;
            Console.WriteLine("Task_2: ( Переданое число: " + num_2 + " ), Результат:" + Reverse_Two(num_2) +"\n");

            //task_3
            string str = "asdabbca";
            Console.WriteLine("Task_3: ( Входная строка: "+ str + " ), Результат: " + SerchMaxLengthSubString(str));

            Console.ReadKey();
        }

        //task_1
        public static int Reverse_One(int num)
        {
            string result = "";

            string nums = num.ToString();

            for (int i = nums.Length - 1; i >= 0; i--)
            {
                result += nums[i];
            }

            return int.Parse(result);
        }

        //task_2
        public static int Reverse_Two(decimal num)
        {
            string result = "";

            decimal nums = num;
            int a = 10;
            int b = 1;

            while (Math.Floor((nums % a) / b) > 0)
            {
                result += Math.Floor((nums % a) / b);
                a *= 10;
                b *= 10;
            }

            return int.Parse(result);
        }

        //task3
        public static string SerchMaxLengthSubString(string text)
        {

            string result = "";
            string sub = "";
            
            List<string> substrings = new List<string>();

            int check = 0;

            int next = 1;
            int i = 0;

            while (i < text.Length)
            {
                for (int j = 0; j < sub.Length; j++)
                {
                    if (text[i] == sub[j])
                    {
                        check = 1;
                    }
                    else if (i == text.Length-1)
                    {
                        check = 2;
                    }
                }

                if (check == 0)
                {
                    sub += text[i];
                    i++;
                }
                else if (check == 1)
                {
                    substrings.Add(sub);
                    
                    check = 0;
                    sub = "";

                    i = next;
                    next++;
                }
                else
                {
                    sub += text[i];
                    substrings.Add(sub);

                    check = 0;
                    sub = "";

                    i = next;
                    next++;
                }
            }


            int max_length = 0;
            foreach (var s in substrings)
            {
                if (s.Length > max_length)
                {
                    max_length = s.Length;
                    result = s;
                }
            }
            return result;
        }
    }
}
