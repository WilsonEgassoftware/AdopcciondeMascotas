using AdopcciondeMascotas.Models;
using System.Collections;
using System.Diagnostics.Contracts;

namespace AdopcciondeMascotas;

public class ApiService : ContentPage
{
    public static object UsuarioActual { get; internal set; }
    public static object MascotaSeleccionada { get; internal set; }

    internal static IEnumerable ObtenerMascotas()
    {
        throw new NotImplementedException();
    }

    public class ApiService : ContentPage
    {
        public static object UsuarioActual { get; internal set; }
        public static object MascotaSeleccionada { get; internal set; }

        internal static IEnumerable ObtenerMascotas()
        {
            throw new NotImplementedException();
        }

        // Fixed duplicate class definition and invalid token '{' issue.
        public static List<Mascota> ObtenerListaDeMascotas()
        {
            // Aquí deberías implementar la lógica para obtener las mascotas desde una API o base de datos.
            // Por ahora, retornaremos una lista de ejemplo.
            return new List<Mascota>
            {
                new Mascota { Id = 1, Nombre = "Firulais", Tipo = "Perro" },
                new Mascota { Id = 2, Nombre = "Luna", Tipo = "Loro" },
                new Mascota { Id = 3, Nombre = "Miau", Tipo = "Gato" }
            };
        }
    }
}
                