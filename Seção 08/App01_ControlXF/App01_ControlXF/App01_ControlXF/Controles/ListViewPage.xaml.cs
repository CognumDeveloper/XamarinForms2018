using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using App01_ControlXF.Modelo;

namespace App01_ControlXF.Controles
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ListViewPage : ContentPage
	{
		public ListViewPage ()
		{
			InitializeComponent ();

            List<Pessoa> lista = new List<Pessoa>();
            lista.Add(new Pessoa { Nome="Denis", Idade="44"});
            lista.Add(new Pessoa { Nome = "Gabriel", Idade = "30" });
            lista.Add(new Pessoa { Nome = "Gisele", Idade = "43" });
            lista.Add(new Pessoa { Nome = "Denis 2", Idade = "45" });
            lista.Add(new Pessoa { Nome = "Denis 3", Idade = "46" });

            ListaPessoas.ItemsSource = lista;
		}
	}
}