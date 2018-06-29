using App01_Vagas.Banco;
using App01_Vagas.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App01_Vagas.Paginas
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ConsultaVagas : ContentPage
	{

        List<Vaga> Lista { get; set; }

		public ConsultaVagas ()
		{
			InitializeComponent ();

            Database database = new Database();
            Lista = database.Consultar();
            ListVagas.ItemsSource = Lista;
            LblCount.Text = Lista.Count.ToString();
		}

        private void BtnMinhasVagas_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MinhasVagasCadastradas());
        }

        private void BtnAdicionar_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CadastroVaga());
        }

        private void GestureDetalhes_Tapped(object sender, EventArgs e)
        {
            Label lblDetalhe = (Label)sender;
            TapGestureRecognizer tapGest = (TapGestureRecognizer)lblDetalhe.GestureRecognizers[0];
            Vaga vaga = tapGest.CommandParameter as Vaga;
            Navigation.PushAsync(new DetalheVaga(vaga));
        }

        private void EntryPesquisar_TextChanged(object sender, TextChangedEventArgs e)
        {
            ListVagas.ItemsSource = Lista.Where(a=>a.NomeVaga.Contains(e.NewTextValue)).ToList();
        }
    }
}