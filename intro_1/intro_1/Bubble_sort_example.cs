using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace intro_1
{
    class Bubble_sort_example
    {

        public static List<T> Bubble_sort<T>(List<T> tosort) where T: IComparable
        {
            T t;

            for (int p = 0; p <= tosort.Count - 2; p++)
            {
                for (int i = 0; i <= tosort.Count - 2; i++)
                {
                    if (tosort[i].CompareTo(tosort[i+1]) > 0)
                    {
                        t = tosort[i + 1];
                        tosort[i + 1] = tosort[i];
                        tosort[i] = t;
                    }
                }
            }

            return tosort;
        }

    }
}
