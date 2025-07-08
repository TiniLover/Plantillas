using Parcial.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial.Dal
{
    internal static class MemoyRepository
    {
        //Persistir Ciudades
        private static List<Ciudad> ciudades = new List<Ciudad>();

        //Persistir Suscripciones
        private static Dictionary<Ciudad, List<Usuario>> suscripciones = new Dictionary<Ciudad, List<Usuario>>();

        internal static void Suscribir(Ciudad ciudad, Usuario usuario)
        {
            //if (suscripciones.ContainsKey(ciudad))

            //List<Usuario> usuarios = suscripciones[ciudad].;

            foreach (var item in suscripciones[ciudad])
            {
                if (item.IdUsuario == usuario.IdUsuario)
                {
                    //El usuario ya está registrado para esta ciudad
                    return; //Utilizar alguna exception
                }
            }

            suscripciones[ciudad].Add(usuario);
        }

        internal static void Desuscribir(Ciudad ciudad, Usuario usuario)
        {
            suscripciones[ciudad].Remove(usuario);
        }

        internal static Dictionary<Ciudad, List<Usuario>> TodasSuscripciones()
        {
            return suscripciones;
        }

        public static void AgregarCiudad(Ciudad ciudad)
        {
            //Control de duplicados
            foreach (Ciudad item in ciudades)
            {
                if(item.Nombre == ciudad.Nombre)
                    return;
            }
            //Agregamos la entrada en el repo de ciudades
            ciudades.Add(ciudad);
            //Además, agregamos la entrada en el diccionario
            suscripciones.Add(ciudad, new List<Usuario>());
        }

        public static List<Ciudad> ObtenerCiudades()
        {
            return ciudades;
        }

        public static List<Usuario> GetByCiudad(Ciudad ciudad)
        {
            return suscripciones[ciudad];
        }
    }
}
