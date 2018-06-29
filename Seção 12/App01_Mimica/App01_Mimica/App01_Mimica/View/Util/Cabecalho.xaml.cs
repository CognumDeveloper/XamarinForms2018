using App01_Mimica.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App01_Mimica.View.Util
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Cabecalho : ContentView
	{
		public Cabecalho ()
		{
			InitializeComponent ();

            BindingContext = new CabecalhoViewModel();
        }

        private void SairEvento(object sender, EventArgs e)
        {
            var viewModel = (CabecalhoViewModel)this.BindingContext;

            if (viewModel.Sair.CanExecute(null))
            {
                viewModel.Sair.Execute(null);
            }
        }
    }
}