using App01_Cell.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App01_Cell.Pagina
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ListViewPage : ContentPage
	{
		public ListViewPage ()
		{
			InitializeComponent ();

            List<Funcionario> Lista = new List<Funcionario>();
            Lista.Add(new Funcionario() { Nome = "José", Cargo = "Presidente" });
            Lista.Add(new Funcionario() { Nome = "Gabriel", Cargo = "Vice-Presidente" });
            Lista.Add(new Funcionario() { Nome = "Gisele", Cargo = "Diretora" });
            Lista.Add(new Funcionario() { Nome = "Anibal", Cargo = "Entregador" });
            Lista.Add(new Funcionario() { Nome = "Fernando", Cargo = "Office-boy" });

            ListaFuncionario.ItemsSource = Lista;
        }

        private void ListaFuncionario_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Funcionario func = (Funcionario)e.SelectedItem;
            Navigation.PushAsync(new Detalhe.DetailPage(func));
        }

        private void MenuItemFerias_Clicked(object sender, EventArgs e)
        {
            MenuItem botao = (MenuItem)sender;
            Funcionario func = (Funcionario)botao.CommandParameter;
            DisplayAlert(("Título: " + func.Nome), "Mensagem: " + func.Nome + " - " + func.Cargo + " EM FÉRIAS. ", "OK");
        }

        private void MenuItemAbono_Clicked(object sender, EventArgs e)
        {
            MenuItem botao = (MenuItem)sender;
            Funcionario func = (Funcionario)botao.CommandParameter;
            DisplayAlert(("Título: " + func.Nome), "Mensagem: " + func.Nome + " - " + func.Cargo + " RECEBEU ABONO. ", "OK");
        }
    }
}