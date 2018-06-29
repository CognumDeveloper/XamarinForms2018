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
	public partial class ListViewButtonPage : ContentPage
	{
		public ListViewButtonPage ()
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

        private void ButtonFerias_Clicked(object sender, EventArgs e)
        {
            Button btnFerias = (Button)sender;
            Funcionario func = (Funcionario)btnFerias.CommandParameter;
            DisplayAlert("Férias", "Funcionário: " + func.Nome, "OK");
        }
    }
}