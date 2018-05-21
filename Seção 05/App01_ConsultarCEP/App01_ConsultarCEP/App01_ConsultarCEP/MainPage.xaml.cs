using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using App01_ConsultarCEP.Servico.Modelo;
using App01_ConsultarCEP.Servico;

namespace App01_ConsultarCEP
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();

            BOTAO.Clicked += BuscarCEP;
		}

        private void BuscarCEP(object Sender, EventArgs args)
        {
            string cep = CEP.Text.Trim();
           if (isValidCEP(cep))
            {
                try
                {
                    Endereco end = ViaCEPServico.BuscarEnderecoViaCEP(cep);

                    if (end != null)
                    {
                        RESULTADO.Text = string.Format("Endereço: {0}-{1}, {2} {3}", end.localidade, end.uf, end.logradouro, end.bairro);
                    }
                    else
                    {
                        RESULTADO.Text = "Endereço não encontrado para o CEP digitado";
                    }
                    
                }
                catch(Exception e)
                {
                    DisplayAlert("Erro", ("Problemas com o WS" + e.Message), "OK");
                }
            }
            else
            {
                RESULTADO.Text = "Sem resultado.";
            }
        }

        private bool isValidCEP(string cep)
        {

            bool valido = true;

            if (cep.Length != 8)
            {
                DisplayAlert("Erro", "CEP inválido! O CEP deve conter 8 caracteres.", "OK"); 
                valido = false;
            }

            int NovoCEP = 0;
            if (!int.TryParse(cep, out NovoCEP))
            {
                DisplayAlert("Erro", "CEP inválido! O CEP deve conter apenas números.", "OK");
                valido = false;
            }
            
            return valido;
        }
	}
}
