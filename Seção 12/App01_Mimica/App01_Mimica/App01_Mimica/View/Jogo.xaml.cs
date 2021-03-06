﻿using App01_Mimica.Model;
using App01_Mimica.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App01_Mimica.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Jogo : ContentPage
	{
		public Jogo (Grupo grupo)
		{
			InitializeComponent ();

            BindingContext = new JogoViewModel(grupo);
		}
	}
}