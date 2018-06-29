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
	public partial class MinhasVagasCadastradas : ContentPage
	{

        List<Vaga> Lista { get; set; }
        public MinhasVagasCadastradas ()
		{
			InitializeComponent ();

            ConsultarVagas();
        }

        private void ConsultarVagas()
        {
            Database database = new Database();
            Lista = database.Consultar();
            ListVagas.ItemsSource = Lista;
            LblCount.Text = Lista.Count.ToString();
        }

        private void GestureEditar_Tapped(object sender, EventArgs e)
        {
            Label lblEditar = (Label)sender;
            TapGestureRecognizer tapGest = (TapGestureRecognizer)lblEditar.GestureRecognizers[0];
            Vaga vaga = tapGest.CommandParameter as Vaga;
            Navigation.PushAsync(new EditarVaga(vaga));
        }

        private void GestureExcluir_Tapped(object sender, EventArgs e)
        {
            Label lblExcluir = (Label)sender;
            TapGestureRecognizer tapGest = (TapGestureRecognizer)lblExcluir.GestureRecognizers[0];
            Vaga vaga = tapGest.CommandParameter as Vaga;

            Database database = new Database();
            database.Exclusao(vaga);
            ConsultarVagas();
        }

        private void EntryPesquisar_TextChanged(object sender, TextChangedEventArgs e)
        {
            ListVagas.ItemsSource = Lista.Where(a => a.NomeVaga.Contains(e.NewTextValue)).ToList();
        }
    }
}