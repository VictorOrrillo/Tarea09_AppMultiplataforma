using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tarea09
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void GuardarButton_Clicked(object sender, EventArgs e)
        {
            Button guardarButton = (Button)sender;
            guardarButton.BackgroundColor = Color.FromHex("#00FF00");

            // Cambiar el color del texto a verde
            NombreEntry.TextColor = Color.Green;
            ApellidoEntry.TextColor = Color.Green;
            CorreoEntry.TextColor = Color.Green;
        }

        private void CancelarButton_Clicked(object sender, EventArgs e)
        {
            Button cancelarButton = (Button)sender;
            cancelarButton.BackgroundColor = Color.FromHex("#FF0000");

            // Cambiar el color del texto a rojo
            NombreEntry.TextColor = Color.Red;
            ApellidoEntry.TextColor = Color.Red;
            CorreoEntry.TextColor = Color.Red;

        }
    }
}