using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace RepasoSemana6
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void BtnInserrtar_Clicked(object sender, EventArgs e)
        {
            try
            {
                WebClient cliente = new WebClient();
                var parametros = new System.Collections.Specialized.NameValueCollection();
                parametros.Add("codigo", TxtCodigo.Text);
                parametros.Add("nombre", TxtNombre.Text);
                parametros.Add("apellido", TxtApellido.Text);
                parametros.Add("edad", TxtEdad.Text);
                

                cliente.UploadValues("http://192.168.124.40/moviles/post.php", "POST", parametros);
                TxtCodigo.Text = "";
                TxtNombre.Text = "";
                TxtApellido.Text = "";
                TxtEdad.Text = "";
                DisplayAlert("Mensaje de Alerta", "Dato Ingresado Correctamanete", "Ok"); 
            }
            catch (Exception)
            {
                DisplayAlert("Error", "Ingreso Incorrecto", "Ok");
            }
        }

        private async void BtnRegresar_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Principal());
        }
    }
}
