using AdopcciondeMascotas.Models;
using System.Collections.Generic;

namespace AdopcciondeMascotas.Services
{
    public static class ApiService
    {
        public static Usuario? UsuarioActual { get; set; }
        public static Mascota? MascotaSeleccionada { get; set; }

        public static List<Mascota> ObtenerMascotas()
        {
            return new List<Mascota>
            {
                new Mascota { Nombre = "Firulais", Tipo = "Perro" },
                new Mascota { Nombre = "Misu", Tipo = "Gato" },
                new Mascota { Nombre = "Loro Pepe", Tipo = "Loro" }
            };
        }
    }
}
