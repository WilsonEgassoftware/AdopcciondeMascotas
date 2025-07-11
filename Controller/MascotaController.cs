
namespace AdopcciondeMascotas.Controller;

public class MascotaController : Controller
{
    
    public IActionResult Elegir()
    {
        var mascotas = new List<Mascota>
        {
            new Mascota { Id = 1, Nombre = "Firulais", Tipo = "Perro" },
            new Mascota { Id = 2, Nombre = "Michi", Tipo = "Gato" },
            new Mascota { Id = 3, Nombre = "Max", Tipo = "Conejo" }
        };

        return View(mascotas);
    }

    
    public IActionResult Elegir(int id)
    {
        var mascota = new Mascota
        {
            Id = id,
            Nombre = id == 1 ? "Firulais" : id == 2 ? "Michi" : "Max",
            Tipo = id == 1 ? "Perro" : id == 2 ? "Gato" : "Conejo"
        };

        TempData["MascotaNombre"] = mascota.Nombre;
        TempData["MascotaTipo"] = mascota.Tipo;
        return RedirectToAction("Resumen", "Final");
    }

    private IActionResult RedirectToAction(string v1, string v2)
    {
        throw new NotImplementedException();
    }
}
