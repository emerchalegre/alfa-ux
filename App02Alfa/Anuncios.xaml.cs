using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net.Http;
using Newtonsoft.Json;
using Xamarin.Forms;

namespace App02Alfa
{
	public partial class Anuncios : ContentPage
	{
		public ObservableCollection<Anuncio> Dados { get; set; }

		public Anuncios()
		{
			BindingContext = this;
			Dados = new ObservableCollection<Anuncio>();
			InitializeComponent();
		}

		protected override void OnAppearing()
		{
			base.OnAppearing();

			CarregaDados();
		}

		async void CarregaDados() 
		{
			var url = "https://classidiario.odiario.com/api/busca";
			var web = new HttpClient();

			var json = await web.GetStringAsync(url);

			var anuncios = JsonConvert.DeserializeObject<List<Anuncio>>(json);

			foreach (var anuncio in anuncios)
			{
				Dados.Add(anuncio);
			}

		}
			
		void Handle_ItemSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
		{
			if (e.SelectedItem == null)
				return;

			var anuncio = (Anuncio)e.SelectedItem;

			Navigation.PushAsync(new Detalhes(anuncio));

			((ListView)sender).SelectedItem = null;
		}
	}
}
