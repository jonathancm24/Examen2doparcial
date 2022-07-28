using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
     abstract class ordenbase
    {
        protected List<Ingrediantes> ingrediantes = new List<Ingrediantes>
        {
            new Ingrediantes{topic="Manjar",preciotopic=0.25},
            new Ingrediantes{topic="Jarabe de chocolate",preciotopic=0.50},
            new Ingrediantes{topic="galletas oreo",preciotopic=0.75}
        };
        protected List<Helados> helados = new List<Helados>
        {
            new Helados{sabor="chocolate",preciosabor=1.25},
            new Helados{sabor="Vainilla",preciosabor=1.35},
            new Helados{sabor="Fresa",preciosabor=1.50}
        };
        public abstract double Preciofinal();
    }
}
