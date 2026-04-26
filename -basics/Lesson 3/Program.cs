using System;
using System.Collections.Generic;


namespace Lesson_3    
{
    internal class Program
    {
        enum Days
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        } 

        // you can comment like this
        /*
         * and like this
         * 
         * 
         * 
         */

        static void Main(string[] args)
        {

            int[] array = new int[10];
            array[0] = 1;
            array[1] = 2;
            array[2] = 3;

            List <int> list = new List<int>();
            list.Add(0);
            list.Add(1);
            list.Add(2);

            List<int> list1 = new List<int>
            {
                1, 2, 3, 4
            };


            /*-------Homework-------
            * 1) to make a list from 5 elements and output to console
            * 2) to make make an array from 5 elements and output to console
            * 3) to make an enum from 5 elements and output to console
            */

            List<int> ints = [1, 2, 3, 4, 5];
            int[] array1 = [1, 2, 3, 4, 5];


            Console.WriteLine($"List: {ints[0]}, {ints[1]}, {ints[2]}, {ints[3]}, {ints[4]}\n");
            Console.WriteLine($"Array: {array1[0]}, {array1[1]}, {array1[2]}, {array1[3]}, {array1[4]}\n");
            Console.WriteLine($"Enum: {En.One}, {En.Two}, {En.Three}, {En.Four}, {En.Five}");
            Console.ReadLine();



        }


        enum En
        {
            One, Two, Three, Four, Five
            

        }
    }
}