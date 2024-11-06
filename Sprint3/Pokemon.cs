using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint3
{
    internal class Pokemon
    {
        public string Name { get; set; }

        public virtual void Catch()
        {
            Console.WriteLine($"Congratulations! You caught {this.Name}.");
        }

        public static void Run()
        {
            Pokemon newPokemon = new Pokemon();
        }
    }
}
