namespace AdopcciondeMascotas.View;

public partial class SeleccionMascotaPage : ContentPage
{
    public SeleccionMascotaPage()
    {
        InitializeComponent();
        mascotasList.ItemsSource = ApiService.ObtenerMascotas();
    }

    private async void OnSeleccionChanged(object sender, SelectionChangedEventArgs e)
    {
        var mascota = e.CurrentSelection.FirstOrDefault() as Models.Mascota;
        if (mascota != null)
        {
            ApiService.MascotaSeleccionada = mascota;
            await Navigation.PushAsync(new ResumenPage());
        }
    }
}