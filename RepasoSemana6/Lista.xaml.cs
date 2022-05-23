using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RepasoSemana6
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Lista : ContentPage
    {
        private const string Url = "http://192.168.124.40/moviles/post.php";
        private readonly HttpClient client = new HttpClient();
        private ObservableCollection<Datos> _post;
        public Lista()
        {
            InitializeComponent();
        }

        private async void BtnConsulatr_Clicked(object sender, EventArgs e)
        {
            var content = await client.GetStringAsync(Url);
            List<Datos> posts = JsonConvert.DeserializeObject<List<Datos>>(content);
            _post = new ObservableCollection<Datos>(posts);

            MyListView.ItemsSource = _post;
        }
    }
}