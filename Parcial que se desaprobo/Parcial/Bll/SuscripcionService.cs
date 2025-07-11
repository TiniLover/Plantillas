using Parcial.Dal;
using Parcial.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial.Bll
{
    internal static class SuscripcionService
    {

        internal static void Suscribir(Usuario usuario, Ciudad ciudad)
        {
            MemoyRepository.Suscribir(ciudad, usuario);
        }

        internal static void Desuscribir(Usuario usuario, Ciudad ciudad)
        {
            MemoyRepository.Desuscribir(ciudad, usuario);
        }

        internal static Dictionary<Ciudad, List<Usuario>> VerSuscripciones()
        {
            return MemoyRepository.TodasSuscripciones();
        }
    }
}
