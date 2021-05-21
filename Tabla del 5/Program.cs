using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabla_del_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 5;
            Console.WriteLine("La tabla del 5");
        
            for(int i = 1; i <= 12; i++)
            {
                int multiplicar = num * i;
                Console.WriteLine("{0} X {1} = {2}", num, i, multiplicar);

            }
            Console.ReadKey();
        }
    }
}
