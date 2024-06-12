using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WSIBC.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WSIBC.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageResultado : ContentPage
    {
        public PageResultado()
        {
            InitializeComponent();
        }
        public PageResultado(Pesquisa pesquisa)
        {
            InitializeComponent();
            txtNome.Text = pesquisa.Nome;
            txtResultado.Text = pesquisa.Resultado.ToString("F");
        }
    }
}