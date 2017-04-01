using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace App02Alfa
{
	public partial class Pagina2 : ContentPage
	{
		public ObservableCollection<String> Nomes { get; set; }

		public Pagina2()
		{
			BindingContext = this;
			Nomes = new ObservableCollection<String>() { "Emerson", "Lurdinha" };
			Nomes.Add("Lara");

			InitializeComponent();

		}

		void Handle_Clicked(object sender, System.EventArgs e)
		{
			Nomes.Add("Luan");

			//Navigation.PopAsync();

			//Navigation.PopToRootAsync();
		}
	}
}
