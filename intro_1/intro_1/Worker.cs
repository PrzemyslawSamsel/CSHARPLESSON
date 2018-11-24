using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace intro_1
{
    class Worker : IComparable
    {
        public string name { get; set; }
        public int wage { get; set; }

        public int CompareTo(object obj)
        {
            if (obj == null) return 1;

            Worker another_worker = obj as Worker;

            if (another_worker != null)
                return this.wage.CompareTo(another_worker.wage);
            else
                throw new ArgumentException("This object is not a worker!");
        }

        public override string ToString()
        {
            return "Worker: " + name + " has a " + wage + " payoff";
        }

    }
}
