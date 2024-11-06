using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint3
{
    class FireTypePokemon : Pokemon
    {
        public static void Burn()
        {
            Console.WriteLine("You got burned!");
        }

        public override void Catch()
        {
            Console.WriteLine($"You caught {this.Name}! Careful, it's hot!");
        }

        public override string ToString()
        {
            return "This is a fire type pokemon";
        }
    }
}
