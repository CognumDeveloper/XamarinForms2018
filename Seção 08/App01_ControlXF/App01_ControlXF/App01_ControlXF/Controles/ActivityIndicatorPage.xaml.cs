using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App01_ControlXF.Controles
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ActivityIndicatorPage : ContentPage
	{
		public ActivityIndicatorPage ()
		{
			InitializeComponent ();
            this.BindingContext = this;
            this.IsBusy = false;
        }

        private void BtnIsRunning(object sender, EventArgs e)
        {
            this.IsBusy = true;
        }
    }
}