using System;
using Microsoft.Maui.Controls;
using productoApp.Layouts;

namespace productoApp
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnInicioClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Layouts.Inicio());
        }
        private void OnRegistroClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Layouts.Registro());
        }

    }
}