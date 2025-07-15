namespace AdopcciondeMascotas.View;

public partial class ResumenPage : ContentPage
{
    private Label? _infoLabel; // Rename the field to avoid ambiguity

    public ResumenPage()
    {
        
    }

    public ResumenPage(Label infoLabel)
    {
        InitializeComponent();
        var usuario = ApiService.UsuarioActual as Models.Usuario; // Ensure proper casting
        var mascota = ApiService.MascotaSeleccionada as Models.Mascota; // Ensure proper casting

        if (usuario != null && mascota != null)
        {
            infoLabel.Text = $"Gracias {usuario.Nombre} ({usuario.Correo}) por adoptar a {mascota.Nombre}, un hermoso {mascota.Tipo}.";
        }
        else
        {
            infoLabel.Text = "Información de usuario o mascota no disponible.";
        }

        this._infoLabel = infoLabel; // Use the renamed field
    }
}