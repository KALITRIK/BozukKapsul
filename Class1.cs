using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp37
{
    class Class1
    {

        public long Tcgir()
        {

            Console.Write("TC Gir: ");
            long TCC = long.Parse(Console.ReadLine());

            return TCC;

        }

        private long tc;
        public long TC 
        {
            get
            {
                return tc;
            }

        set
            {
                value = Tcgir();
                tc = value;
            }
        }

    }
}
