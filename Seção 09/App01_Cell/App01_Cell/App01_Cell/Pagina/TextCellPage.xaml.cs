using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using App01_Cell.Modelo;

namespace App01_Cell.Pagina
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class TextCellPage : ContentPage
	{
		public TextCellPage ()
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
    }
}