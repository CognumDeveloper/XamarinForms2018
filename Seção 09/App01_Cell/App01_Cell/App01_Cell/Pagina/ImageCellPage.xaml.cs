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
	public partial class ImageCellPage : ContentPage
	{
		public ImageCellPage ()
		{
			InitializeComponent ();

            List<Funcionario> Lista = new List<Funcionario>();
            Lista.Add(new Funcionario() { Nome = "José", Cargo = "Presidente", Foto = "https://cdn.xl.thumbs.canstockphoto.com.br/imagem-vetorial-galo-cliparte-vetor_csp40853703.jpg" });
            Lista.Add(new Funcionario() { Nome = "Gabriel", Cargo = "Vice-Presidente", Foto = "http://3.bp.blogspot.com/-CwkBxyNLlMM/TibkyUFhNEI/AAAAAAAAAYE/t05bA7z8ckg/s200/funcionario.png" });
            Lista.Add(new Funcionario() { Nome = "Gisele", Cargo = "Diretora", Foto = "https://cdn.xl.thumbs.canstockphoto.com.br/vetorial-imagem-de-um-camelo-vetor-cliparte_csp12853452.jpg" });
            Lista.Add(new Funcionario() { Nome = "Anibal", Cargo = "Entregador", Foto = "https://cdn.xl.thumbs.canstockphoto.com/canstock33937007.jpg" });
            Lista.Add(new Funcionario() { Nome = "Fernando", Cargo = "Office-boy", Foto = "https://cdn.xl.thumbs.canstockphoto.com.br/a-vetorial-imagem-a-borboleta-vetor-cliparte_csp8742035.jpg" });

            ListaFuncionario.ItemsSource = Lista;
        }
    } 
}