namespace AdopcciondeMascotas.Controller;

public class RegistroController : Controller
{
    
    public IActionResult Index() => View();

  
    public IActionResult Index(Usuario usuario)
    {
        TempData["Nombre"] = usuario.Nombre;
        TempData["Correo"] = usuario.Correo;
        return RedirectToAction("Elegir", "Mascota");
    }
}
