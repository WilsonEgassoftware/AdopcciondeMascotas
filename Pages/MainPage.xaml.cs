using AdopcciondeMascotas.Models;
using AdopcciondeMascotas.PageModels;

namespace AdopcciondeMascotas.Pages
{
    public partial class MainPage : ContentPage
    {
        public MainPage(MainPageModel model)
        {
            InitializeComponent();
            BindingContext = model;
        }
    }
}