﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ember
{
    class Program
    {
        static void Main(string[] args)
        {
            Sportolo sportolo = new Sportolo("triatlon", "Elek", 81, 180, 2003);

            sportolo.Mozog();
            sportolo.Sportol();
            Console.WriteLine(sportolo.Eletkor());
            Console.WriteLine(sportolo.ToString());

            Console.ReadKey();
        }
    }
}