using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace intro_1
{
    class Class1
    {
        public static void my_method1()
        {
            Console.WriteLine("This is method1 from class1");

            int[] t = {1,8,2,5};
            
            
            List<int> mylist1 = new List<int>();
            mylist1.InsertRange(0, t);

            Console.WriteLine("Original array :");
            foreach (int aa in mylist1)
                Console.Write(aa + " ");

            Console.WriteLine();

            mylist1 = Bubble_sort_example.Bubble_sort(mylist1);

            

            Console.WriteLine("Sorted array :");
            foreach (int aa in mylist1)
                Console.Write(aa + " ");

            Console.WriteLine();
            Console.ReadKey();

        }
    }
}
