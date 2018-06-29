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
	public partial class CadastroVaga : ContentPage
	{
		public CadastroVaga ()
		{
			InitializeComponent ();
		}

        private void BtnSalvar_Clicked(object sender, EventArgs e)
        {
            Vaga vaga = new Vaga();
            vaga.NomeVaga = NomeVaga.Text;
            vaga.Quantidade = short.Parse(Quantidade.Text);
            vaga.Salario = double.Parse(Salario.Text);
            vaga.Empresa = Empresa.Text;
            vaga.Cidade = Cidade.Text;
            vaga.Descricao = Descricao.Text;
            vaga.TipoContratacao = (TipoContratacao.IsToggled) ? "PJ" : "CLT";
            vaga.Telefone = Telefone.Text;
            vaga.Email = Email.Text;

            Database database = new Database();
            database.Cadastro(vaga);

            App.Current.MainPage = new NavigationPage(new ConsultaVagas());
        }
    }
}