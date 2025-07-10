using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial.Domain
{
    internal class Clima
    {
        public DateTime Fecha { get; set; }

        //Monitoreamos la temperatura...
        public int Temperatura { get; set; }

        public Clima(int temperatura)
        {
            this.Temperatura= temperatura;
        }
    }
}
