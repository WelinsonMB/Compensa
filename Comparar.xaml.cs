using Microsoft.Maui.Controls;
using System;

namespace Compensa
{
    public partial class Comparar : ContentPage
    {
        string marca;
        string modelo;

  
        public Comparar(string marca, string modelo)
        {
            InitializeComponent();
            this.marca = marca;
            this.modelo = modelo;
        }

        private async void VoltarButton_Clicked(object sender, EventArgs e)
        {
            // Volta para a página anterior na pilha de navegação
            await Navigation.PopAsync();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                double etanol = Convert.ToDouble(txt_etanol.Text);
                double gasolina = Convert.ToDouble(txt_gasolina.Text);

                string msg = "";

                if (etanol <= (gasolina * 0.7))
                {
                    msg = $"{marca} {modelo}: O etanol está compensando.";
                }
                else
                {
                    msg = $"{marca} {modelo}: A gasolina está compensando.";
                }

                DisplayAlert("Calculado", msg, "OK");
            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "Fechar");
            }
        }
    }
}
