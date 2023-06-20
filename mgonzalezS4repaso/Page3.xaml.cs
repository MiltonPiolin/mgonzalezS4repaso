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
    public partial class Page3 : ContentPage
    {
        public Page3(string usuario, double numero, string alumno)
        {
            InitializeComponent();

            lblUsuario.Text = "Usuario conectado: " + usuario;
            txtDato.Text = numero.ToString();
            txtEstudainte.Text = "El Alumno es: " + alumno;
        }
    }
}