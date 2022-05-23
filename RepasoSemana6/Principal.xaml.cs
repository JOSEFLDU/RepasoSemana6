using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RepasoSemana6
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Principal : ContentPage
    {
        public Principal()
        {
            InitializeComponent();
        }

        private async void BtnRegistrar_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }

        private async void BtnActualizar_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Actualizar());
        }

        private async void BtnEliminar_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Eliminar());
        }

        private async void BtnListar_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Lista());
        }
    }
}