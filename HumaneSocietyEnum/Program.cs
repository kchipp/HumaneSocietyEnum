using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSocietyEnum
{
    class Program
    {
        static void Main(string[] args)
        {
            Animals seeAnimals = new Animals();
            seeAnimals.view();
            Console.ReadKey();
        }
    }
}
