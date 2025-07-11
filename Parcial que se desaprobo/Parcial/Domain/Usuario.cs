using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial.Domain
{
    internal class Usuario : IObserver
    {
        public int IdUsuario { get; set; }

        public string Nombre { get; set; }

        public void Actualizar(Ciudad ciudad, Clima clima)
        {
            Console.WriteLine($"Soy {Nombre} y recibo notificación Ciudad:{ciudad.Nombre} clima-temperatura: {clima.Temperatura}");
        }
    }
}
