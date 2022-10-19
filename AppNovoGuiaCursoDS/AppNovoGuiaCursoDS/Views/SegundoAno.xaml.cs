using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using AppNovoGuiaCursoDS.Models;

namespace AppNovoGuiaCursoDS.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SegundoAno : ContentPage
    {
        public SegundoAno()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                var c = new Componente
                {
                    Nome = "Programação Web 2",
                    AtribuicoesResponsabilidades = "Planejar projetos de sistemas de informação para web ",
                    ValoresAtitudes = "Responsabilizar-se pela produção, utilização e divulgação de informações. " +
                    "• Incentivar a criatividade. "
                };

                await Navigation.PushAsync(new VerComponente(c));

            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }
        }
        private async void Button_Clicked_2(object sender, EventArgs e)
        {
            try
            {
                var c = new Componente
                {
                    Nome = "Desenvolvimento de Sistemas",
                    AtribuicoesResponsabilidades = "Analisar e projetar sistemas de informação, selecionando linguagens " +
                                                   "de programação e ambientes de desenvolvimento de acordo com as especificações do " +
                                                   "projeto. • Codificar e depurar programas. ",

                    ValoresAtitudes = "Fortalecer a persistência e o interesse na resolução de situações problema. • Incentivar ações " +
                                      "que promovam a cooperação. • Desenvolver a criatividade. "
                };

                await Navigation.PushAsync(new VerComponente(c));
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }
        }

        private async void Button_Clicked_2(object sender, EventArgs e)
        {
            try
            {
                var c = new Models.Componente()
                {
                    Nome = "Programação Mobile 1",
                    AtribuicoesResponsabilidades = "Elaborar projetos de aplicativos para plataformas móveis. ",

                    ValoresAtitudes = "Incentivar a criatividade. • Responsabilizar-se pela produção, utilização e divulgação de " +
                                      "informações. • Estimular a organização. "
                };

                await Navigation.PushAsync(new VerComponente(c));
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }
        }

        private async void Button_Clicked_3(object sender, EventArgs e)
        {
            try
            {
                var c = new Models.Componente()
                {
                    Nome = "Banco de Dados 2",
                    AtribuicoesResponsabilidades = "Desenvolver, gerenciar e implementar um banco de dados. ",

                    ValoresAtitudes = "Incentivar a criatividade. • Desenvolver a criticidade. • Fortalecer a percistência e o" +
                                      "interesse na resolução de situações-problema "
                };

                await Navigation.PushAsync(new VerComponente(c));
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }
        }

        private async void Button_Clicked_4(object sender, EventArgs e)
        {
            try
            {
                var c = new Models.Componente()
                {
                    Nome = "Sistemas Embarcados ",
                    AtribuicoesResponsabilidades = "Desenvolver nprojetos físicos de sistemas embarcados. ",

                    ValoresAtitudes = "Incentivar a criatividade. • Desenvolver a criticidade. • Fortalecer a percistência e o" +
                                      "interesse na resolução de situações-problema "
                };

                await Navigation.PushAsync(new VerComponente(c));
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }
        }
    }
}