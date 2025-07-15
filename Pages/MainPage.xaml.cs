using AdopcciondeMascotas.Models;
using AdopcciondeMascotas.PageModels;

namespace AdopcciondeMascotas.Pages
{
    public partial class MainPage : ContentPage
    {
        public MainPage(MainPageModel model)
        {
            object value = InitializeComponent();
            BindingContext = model;
        }

        private object InitializeComponent()
        {
            throw new NotImplementedException();
        }
    }
}