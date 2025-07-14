using AdopcciondeMascotas.Models;

namespace AdopcciondeMascotas
{
    public interface IApiService
    {
        static abstract Mascota MascotaSeleccionada { get; set; }
        static abstract Usuario UsuarioActual { get; set; }

        static abstract List<Mascota> ObtenerMascotas();
    }
}