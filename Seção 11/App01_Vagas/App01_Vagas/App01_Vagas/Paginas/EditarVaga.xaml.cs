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
	public partial class EditarVaga : ContentPage
	{

        public Vaga _vaga { get; set; }
        public EditarVaga (Vaga vaga)
		{
			InitializeComponent ();
            this._vaga = vaga;

            NomeVaga.Text = vaga.NomeVaga;
            Quantidade.Text = vaga.Quantidade.ToString();
            Salario.Text = vaga.Salario.ToString();
            Empresa.Text = vaga.Empresa;
            Cidade.Text = vaga.Cidade;
            Descricao.Text = vaga.Descricao;
            TipoContratacao.IsToggled = (vaga.TipoContratacao == "CLT") ? false : true;
            Telefone.Text = vaga.Telefone;
            Email.Text = vaga.Email;
        }

        private void BtnSalvar_Clicked(object sender, EventArgs e)
        {

            _vaga.NomeVaga = NomeVaga.Text;
            _vaga.Quantidade = short.Parse(Quantidade.Text);
            _vaga.Salario = double.Parse(Salario.Text);
            _vaga.Empresa = Empresa.Text;
            _vaga.Cidade = Cidade.Text;
            _vaga.Descricao = Descricao.Text;
            _vaga.TipoContratacao = (TipoContratacao.IsToggled) ? "PJ" : "CLT";
            _vaga.Telefone = Telefone.Text;
            _vaga.Email = Email.Text;

            Database database = new Database();
            database.Atualizacao(_vaga);

            App.Current.MainPage = new NavigationPage(new MinhasVagasCadastradas());
        }
    }
}