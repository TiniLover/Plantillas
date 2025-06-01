using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Entity
    {
        public int velocidad { get; set; }
        public string jugador { get; set; }
        public int salud { get; set; } = 100;
        public int golpeDebil { get; set; } = 5;
        public int golpeIntermedio { get; set; } = 10;
        public int golpeFuerte { get; set; } = 20;
    }
}
