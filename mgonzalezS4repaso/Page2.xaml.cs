using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace mgonzalezS4repaso
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page2 : ContentPage
    {
        string user;
        public Page2(string usuario)
        {
            InitializeComponent();

            lblUsuario.Text = "Usuario Conectado: " + usuario;
            user = usuario;

        }

        private void txtDato_TextChanged(object sender, TextChangedEventArgs e)
        {
            
            try
            {
                double dato = Convert.ToDouble(txtDato.Text);
                if (dato>100)
                {
                    DisplayAlert("ERROR", "El dato no esta en el rango", "Cerrar");
                    txtDato.Text = "";


                }
            }
            catch (Exception ex)
            {
                //DisplayAlert("ERROR", ex.Message, "Cerrar");
            }
        }

        private void btnAbrir_Clicked(object sender, EventArgs e)
        {
            double numero = Convert.ToDouble(txtDato.Text);
            string alumno = pkrAumnos.Items[pkrAumnos.SelectedIndex];
            
            Navigation.PushAsync(new Page3(user, numero, alumno));
        }
    }
}