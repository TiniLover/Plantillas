using Parcial.Bll;
using Parcial.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Usuario us1 = new Usuario();
            us1.IdUsuario = 1;
            us1.Nombre = "Jorgito";

            Usuario us2 = new Usuario();
            us2.IdUsuario = 2;
            us2.Nombre = "Pepito";

            Ciudad ciudad1 = new Ciudad();
            ciudad1.Nombre = "Vicente Lopez";

            Ciudad ciudad2 = new Ciudad();
            ciudad2.Nombre = "Mendoza";

            ClimaService.AgregarCiudad(ciudad1);
            ClimaService.AgregarCiudad(ciudad2);

            foreach (var item in ClimaService.ObtenerCiudades())
            {
                Console.WriteLine(item.Nombre);
            }

            SuscripcionService.Suscribir(us1, ciudad1);
            SuscripcionService.Suscribir(us1, ciudad2);
            SuscripcionService.Suscribir(us2, ciudad2);

            foreach (var item in SuscripcionService.VerSuscripciones())
            {
                Console.WriteLine($"Suscriptos para la ciudad {item.Key.Nombre}");

                foreach (var usuario in item.Value)
                {
                    Console.WriteLine($"Usuario nombre: {usuario.Nombre}");
                }
            }

            //Notificación de cambios en el clima de una ciudad
            ClimaService.ActualizarClima(ciudad1, new Clima(24));
            //2da versión con control del estado del clima en la ciudad
            //ClimaService.ActualizarClima(ciudad1, new Clima(24));

            ClimaService.ActualizarClima(ciudad2, new Clima(20));            
        }
    }
}
