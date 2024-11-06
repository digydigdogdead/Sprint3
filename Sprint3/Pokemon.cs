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

        public static void Catch()
        {
            Console.WriteLine("Congratulations! You caught a Pokémon.");
        }

        public static void Run()
        {
            Pokemon newPokemon = new Pokemon();
        }
    }
}
