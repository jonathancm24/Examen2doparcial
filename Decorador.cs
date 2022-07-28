using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Decorador : ordenbase
    {
        protected ordenbase Ordenbase;

        public override double Preciofinal()
        {
            return Ordenbase.Preciofinal();
        }
    }
}
