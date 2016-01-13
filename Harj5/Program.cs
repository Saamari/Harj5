using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harj5
{
    class Program
    {
        static void Main(string[] args)
            {
            int time;
            int hour;
            int min;
            int sec;
               
            Console.WriteLine("Anna sekuntti määrät");
          time = int.Parse(Console.ReadLine());
            hour = time / 3600;
            min = (time - hour *3600) / 60;
            sec = (time - hour * 3600 - min * 60);
            Console.WriteLine("Tunnit {0}", hour);
            Console.WriteLine("Minuutit {0}", min);
            Console.WriteLine("Sekunnit {0}", sec);





        }
    }
}
