using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App01_Vagas.Banco;
using System.IO;
using Xamarin.Forms;
using App01_Vagas.UWP.Banco;
using Windows.Storage;

[assembly: Dependency(typeof(Caminho))]
namespace App01_Vagas.UWP.Banco
{
    public class Caminho : ICaminho
    {
        public string ObterCaminho(string NomeArquivoBanco)
        {
            string caminhoDaPasta = ApplicationData.Current.LocalFolder.Path;
            string caminhoBanco = Path.Combine(caminhoDaPasta, NomeArquivoBanco);
            return caminhoBanco;
        }
    }
}
