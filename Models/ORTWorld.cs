using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TP04_Paquetes_Turisticos.Models
{
    public class ORTWorld
    {
        public List<string> ListaDestinos { get; private set; }
        public List<string> ListaHoteles { get; private set; }
        public List<string> ListaAereos { get; private set; }
        public List<string> ListaExcursiones { get; private set; }
        public static Dictionary<string, List<Paquete>> Paquetes { get; private set; }

        public ORTWorld()
        {
            ListaDestinos = new List<string>
            {
                "Paris",
                "New York",
                "Tokyo",
                "London",
                "Rome",
                "Sydney",
                "Cape Town",
                "Barcelona",
                "Dubai",
                "Rio de Janeiro"
            };

            ListaHoteles = new List<string>
            {
                "hotel1.jpg",
                "hotel2.jpg",
                "hotel3.jpg",
                "hotel4.jpg",
                "hotel5.jpg",
                "hotel6.jpg",
                "hotel7.jpg",
                "hotel8.jpg",
                "hotel9.jpg",
                "hotel10.jpg"
            };

            ListaAereos = new List<string>
            {
                "aereo1.jpg",
                "aereo2.jpg",
                "aereo3.jpg",
                "aereo4.jpg",
                "aereo5.jpg",
                "aereo6.jpg",
                "aereo7.jpg",
                "aereo8.jpg",
                "aereo9.jpg",
                "aereo10.jpg"
            };

            ListaExcursiones = new List<string>
            {
                "excursion1.jpg",
                "excursion2.jpg",
                "excursion3.jpg",
                "excursion4.jpg",
                "excursion5.jpg",
                "excursion6.jpg",
                "excursion7.jpg",
                "excursion8.jpg",
                "excursion9.jpg",
                "excursion10.jpg"
            };

            Paquetes = new Dictionary<string, List<Paquete>>();
        }

        public ORTWorld(List<string> listaDestinos, List<string> listaHoteles, List<string> listaAereos, List<string> listaExcursiones, Dictionary<string, List<Paquete>> paquetes)
        {
            ListaDestinos = listaDestinos;
            ListaHoteles = listaHoteles;
            ListaAereos = listaAereos;
            ListaExcursiones = listaExcursiones;
            Paquetes = paquetes;
        }

        public static bool IngresarPaquete(string destinoSeleccionado, Paquete paquete)
        {
            // Check if the destination already exists in the dictionary
            if (Paquetes.ContainsKey(destinoSeleccionado))
            {
                // Destination exists, add the package to the existing list
                Paquetes[destinoSeleccionado].Add(paquete);
                return true;
            }
            else
            {
                // Destination does not exist, create a new entry
                Paquetes[destinoSeleccionado] = new List<Paquete> { paquete };
                return true;
            }
        }
    }
}