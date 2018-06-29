using App02_ListaBrasil.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App02_ListaBrasil
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Municipios : ContentPage
    {
        private List<Municipio> ListaInternaMunicipio { get; set; }
        private List<Municipio> ListaFiltradaMunicipio { get; set; }
        public Municipios(Estado estado)
        {
            InitializeComponent();

            ListaInternaMunicipio = Servico.Servico.GetMunicipios(estado.id);
            ListaMunicipios.ItemsSource = ListaInternaMunicipio;

        }

        private void TxtMunicipio_TextChanged(object sender, TextChangedEventArgs e)
        {
            ListaFiltradaMunicipio = ListaInternaMunicipio.Where(a => a.nome.Contains(e.NewTextValue)).ToList();
            ListaMunicipios.ItemsSource = ListaFiltradaMunicipio;
        }
    }
}