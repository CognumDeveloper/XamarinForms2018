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
	public partial class SliderSteperPage : ContentPage
	{
		public SliderSteperPage ()
		{
			InitializeComponent ();
		}

        private void SliderValueChanged(object sender, ValueChangedEventArgs e)
        {
            sliderResult.Text = e.NewValue.ToString();
        }

        private void StepperValueChanged(object sender, ValueChangedEventArgs e)
        {
            stepperResult.Text = e.NewValue.ToString();
        }
    }
}