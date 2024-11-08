namespace Compensa
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_clicked(object sender, EventArgs e)
        {
            string marca = txt_marca.Text;
            string modelo = txt_modelo.Text;

            await Navigation.PushAsync(new Comparar(marca, modelo));
        }
    }

}
