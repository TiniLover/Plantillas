using Parcial.Dal;
using Parcial.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial.Bll
{
    //SUBJECT
    internal static class ClimaService
    {
        internal static void AgregarCiudad(Ciudad ciudad)
        {
            MemoyRepository.AgregarCiudad(ciudad);
        }

        internal static List<Ciudad> ObtenerCiudades()
        {
            return MemoyRepository.ObtenerCiudades();
        }

        internal static void ActualizarClima(Ciudad ciudad, Clima clima)
        {
            //1) Ir al repositorio y persistir el clima actual de la
            //ciudad (Opcional)

            //1) Se puede poner una regla de negocio para notificar
            //Solamente cuando haya cambios en el estado pertinente            

            //2) Notificar a todos los suscriptores de la ciudad 
            //seleccionada invocando el método de Ibserver
            Notificar(ciudad, clima);
        }

        private static void Notificar(Ciudad ciudad, Clima clima)
        {
            foreach (var item in MemoyRepository.GetByCiudad(ciudad))
            {
                item.Actualizar(ciudad, clima);
            } 
        }
    }
}
