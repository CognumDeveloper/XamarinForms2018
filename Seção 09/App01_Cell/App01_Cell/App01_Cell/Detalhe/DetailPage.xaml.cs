using App01_Cell.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App01_Cell.Detalhe
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DetailPage : ContentPage
	{
		public DetailPage (Funcionario funcionario)
		{
			InitializeComponent ();

            TxtNome.Text = funcionario.Nome;
		}
	}
}