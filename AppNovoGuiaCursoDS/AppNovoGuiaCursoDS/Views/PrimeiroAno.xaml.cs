using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppNovoGuiaCursoDS.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PrimeiroAno : ContentPage
    {
        public PrimeiroAno()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                var c = new Componente
                {
                    Nome = "Linguagem, Trabalho e Tecnologia",

                    AtribuicoesResponsabilidades = "Comunicar-se em língua portuguesa, utilizando o vocabulário técnico da área e " +
                                                   "elaborar registros e planilhas de acompanhamento e controle de atividades",

                    ValoresAtitudes = "Incentivar o diálogo e a interlocução. • Responsabilizar-se pela produção, utilização e " +
                                      "divulgação de informações. • Estimular a proatividade. ",
                };

                await Navigation.PushAsync(new VerComponente(c));
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }
        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            try
            {
                var c = new Componente
                {
                    Nome = "Programação e Algoritmos",

                    AtribuicoesResponsabilidades = "• Implementar algoritmos em lingagem de programação, utilizando ambientes de " +
                                                   "desenvolvimento de acordo com as necessidades.  ",

                    ValoresAtitudes = "• Estimular a organização. • Incentivar atitudes de autonomia. • Fortalecer a persistência " +
                                      "e o interesse na resolução de situações-problema.  "
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
                    Nome = "Banco de Dados 1",

                    AtribuicoesResponsabilidades = "Estimular a organização • Fortalecer a persistência e o inetresse na resolução " +
                                                   "de situações-problema. • Promover ações que consideram o respeito ás normas estabelecidas. "
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
                var c = new Componente
                {
                    Nome = "Análise de Sistemas",

                    AtribuicoesResponsabilidades = "Elaborar projetos de sistemas de informação.  ",

                    ValoresAtitudes = "Estimular a organização. • Incentivar a criatividade. • Fortalecer a precistência " +
                                      "e o interesse na resolução de situações-problema.  "
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
                var c = new Componente
                {
                    Nome = "Design Digital",

                    AtribuicoesResponsabilidades = "Desenvolver elementos gráficos para aplicativos e sites.  ",

                    ValoresAtitudes = "Incentivar a criatividade. • Respeitar as manifestações culturais de outros povos" +
                                      "• Incentivar ações que promovam a cooperação. "
                };

                await Navigation.PushAsync(new VerComponente(c));
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }
        }

        private async void Button_Clicked_5(object sender, EventArgs e)
        {
            try
            {
                var c = new Componente
                {
                    Nome = "Programação Web 1",

                    AtribuicoesResponsabilidades = "Desenvolver sites para Web ",

                    ValoresAtitudes = "Incentivar a criatividade. • Estimular a organização. • Fortalecer a persistência " +
                                      "e o interesse na resolução de situações-problema. "
                };

                await Navigation.PushAsync(new VerComponente(c));
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }
        }

        private async void Button_Clicked_6(object sender, EventArgs e)
        {
            try
            {
                var c = new Componente
                {
                    Nome = "Fundamentos da Informática",

                    AtribuicoesResponsabilidades = "Operar sistemas computacionais. ",

                    ValoresAtitudes = "Desenvolver a criticidade. • Incentivar comportamentos éticos. • Promover  " +
                                      "ações que consideram o respeito ás normas estabelecidas. "
                };

                await Navigation.PushAsync(new VerComponente(c));
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }
        }

        private async void Button_Clicked_7(object sender, EventArgs e)
        {
            try
            {
                var c = new Componente
                {
                    Nome = "Técnicas de Programação",

                    AtribuicoesResponsabilidades = "Desenvolver a criticidade. • Incentivar comportamentos éticos. • Promover  " +
                                                   "• Reali8zar versionamento no desenvolvimento de programas.  • Verificar " +
                                                   "usabilidade no desenvolvimento de programas.  ",

                    ValoresAtitudes = "Incentivar a criatividade. • Incentivar comportamentos éticos. Fortalecer a persistência e" +
                                      "o interesse na resolução de situações-problema.  "
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