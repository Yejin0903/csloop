﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace csloop
{
    class Program
    {
        static void Main(string[] args)
        {
            long start = DateTime.Now.Ticks;
            long count = 0;
            while (start + (10000000) > DateTime.Now.Ticks)
            {
                count++;
            }
            Console.WriteLine(count + "만큼 반복함");



            string[] array = { "사과", "배", "포도", "딸기", "바나나" };
            foreach (string item in array)
            {
                Console.WriteLine(item);
            }

            /*int x = 1;
            while (x < 50)
            {
                Console.Clear();
                Console.SetCursorPosition(x, 5);

                if (x % 3 == 0)
                    Console.WriteLine("__@");
                else if (x % 3 == 1)
                    Console.WriteLine("_^@");
                else
                    Console.WriteLine("^_@");

                Thread.Sleep(100);
                x++;
                
            }*/

            int[] array1 = new int[10];

            foreach (var item in array1)
            {
                Console.WriteLine(item);
            }




            //05_for문을 while문으로 바꾸기
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("출력");
            }

            int i = 0;
            int[] num = new int[10];
            while (i < num.Length)
            {
                Console.WriteLine("출력");
                i++;
            }


        }
    }
}
