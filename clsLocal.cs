using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryBlaiotta
{
     class clsLocal
    {
        public string Nombre { get; set; }
        public List<Reserva> Reservas { get; set; } // Lista de reservas

        public class LocalDeTeatro
        {
            public string Nombre { get; set; }
            public List<Reserva> Reservas { get; set; } // Lista de reservas

            // Constructor para inicializar un LocalDeTeatro con un nombre
            public LocalDeTeatro(string nombre)
            {
                Nombre = nombre;
                Reservas = new List<Reserva>(); // Inicializar la lista de reservas
            }
        }
        public class Reserva
        {
            public string Cliente { get; set; }
            public int Fila { get; set; }
            public int Columna { get; set; }
        }
    }
}
