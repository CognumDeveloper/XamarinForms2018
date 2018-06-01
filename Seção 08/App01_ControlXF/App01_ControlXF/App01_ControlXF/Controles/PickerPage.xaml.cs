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
	public partial class PickerPage : ContentPage
	{
		public PickerPage ()
		{
			InitializeComponent ();
		}

        private void SelectedIndexChanged(object sender, EventArgs e)
        {
            Picker obj = (Picker)sender;
            lblResultado.Text = obj.SelectedItem.ToString() + " - " + obj.SelectedIndex.ToString();
        }
    }
}