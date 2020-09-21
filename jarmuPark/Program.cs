using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jarmuPark
{
    class Program
    {
        static void Main(string[] args)
        {
            Auto lada = new Auto("piros","Lada 2112",11);
            Auto trabant = new Auto("zöld","Trabant 1.1",8);

            lada.Tankol(20);
            trabant.Tankol(20);
            lada.Allapot();
            trabant.Allapot();

            Console.WriteLine("Hány kilométert tett meg?");
            int h = int.Parse(Console.ReadLine());
            lada.Megy(h);
            lada.Allapot();
            trabant.Megy(h);
            trabant.Allapot();

            Console.WriteLine("Az autó kilométer óra állása: {0}",lada.KM);
            Console.ReadKey();
        }
    }
}
