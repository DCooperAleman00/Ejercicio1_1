using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ejercico1_1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class resultado : ContentPage
    {
        public resultado()
        {
            InitializeComponent();
        }
        public resultado(String resultado)
        {
            InitializeComponent();
            lblMostrarResultado.Text = "Resultado: " + resultado;

        }

    }
}