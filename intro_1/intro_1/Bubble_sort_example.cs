using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace intro_1
{
    class Bubble_sort_example
    {

        public static List< int > Bubble_sort(List<int> tosort)
        {
            int t;


            for (int p = 0; p <= tosort.Count - 2; p++)
            {
                for (int i = 0; i <= tosort.Count - 2; i++)
                {
                    if (tosort[i] > tosort[i + 1])
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
