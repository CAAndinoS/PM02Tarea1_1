using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PM02Tarea1_1.Operaciones
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DivisionResultado : ContentPage
    {
        public DivisionResultado(String r)
        {
            InitializeComponent();
            division.Text = "El resultado de la División es: " + r;
        }
    }
}