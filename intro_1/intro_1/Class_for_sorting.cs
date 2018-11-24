using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace intro_1
{
    class Class_for_sorting
    {
        public static void my_method1()
        {
            Console.WriteLine("This is method1 from class_for_sorting");

            //Creating list used for sorting
            Random rnd = new Random();
            int[] t = new int[10];

            for(int i =0; i<t.Length;i++)
                t[i] = rnd.Next(1, 100);

            List<int> mylist1 = new List<int>();
            mylist1.InsertRange(0, t);


            Console.WriteLine("Original array:");
            foreach (int aa in mylist1)
                Console.Write(aa + " ");

            Console.WriteLine();

            mylist1 = Bubble_sort_example.Bubble_sort<int>(mylist1);
            
            Console.WriteLine("Sorted array:");
            foreach (int aa in mylist1)
                Console.Write(aa + " ");


            my_method2();

            Console.WriteLine();
            Console.ReadKey();

        }

        public static void my_method2()
        {
            Random rnd = new Random();

            //Sorting custom objects:
            List<Worker> mylist2 = new List<Worker>();
            Worker[] t1 = new Worker[10];

            for (int i = 0; i < t1.Length; i++)
                t1[i] = new Worker { name = "abc", wage = rnd.Next(1, 100) };
            mylist2.InsertRange(0, t1);

            Console.WriteLine("Original array:");
            foreach (var aa in mylist2)
                Console.Write("< " + aa + " >");

            Console.WriteLine();

            mylist2 = Bubble_sort_example.Bubble_sort<Worker>(mylist2);

            Console.WriteLine("Sorted array:");
            foreach (var aa in mylist2)
                Console.Write("< " + aa + " >");
        }
    }
}
