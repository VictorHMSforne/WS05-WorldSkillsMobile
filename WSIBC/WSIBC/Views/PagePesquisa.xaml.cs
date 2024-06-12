using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using WSIBC.Models;
using WSIBC.Services;

namespace WSIBC.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PagePesquisa : ContentPage
    {
        public PagePesquisa()
        {
            InitializeComponent();
        }

        private void slPergunta1_ValueChanged(object sender, ValueChangedEventArgs e)
        {

            txtPergunta1.Text = ((Slider)slPergunta1).Value.ToString("0");
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                Pesquisa pesquisa = new Pesquisa();

                pesquisa.Nome = txtNome.Text  ;
                pesquisa.Pergunta1  = Convert.ToInt32(slPergunta1.Value);
                pesquisa.Pergunta2 = Convert.ToInt32(slPergunta2.Value);
                pesquisa.Pergunta3 = Convert.ToInt32(slPergunta3.Value);

                
                if (string.IsNullOrEmpty(txtNome.Text))
                {
                    DisplayAlert("Nome", "Digite seu Nome, Por Favor", "Ok");
                }
                else
                {
                    int soma = pesquisa.Pergunta1 + pesquisa.Pergunta2 + pesquisa.Pergunta3;
                    double resultado = (((Convert.ToDouble(soma) / 3) - 1) / 9) * 100;
                    pesquisa.Resultado = resultado;
                    ServicesDBPesquisa db = new ServicesDBPesquisa(App.DbPath);
                    db.Inserir(pesquisa);
                    Navigation.PushAsync(new PageResultado(pesquisa));
                    


                }
            }
            catch (Exception er)
            {
                DisplayAlert("Erro", er.Message,"OK");
            }
           
        }

        private void slPergunta2_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            txtPergunta2.Text = ((Slider)slPergunta2).Value.ToString("0");
        }

        private void slPergunta3_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            txtPergunta3.Text = ((Slider)slPergunta3).Value.ToString("0");
        }
    }
}