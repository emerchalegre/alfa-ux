using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using Xamarin.Forms;

namespace App02Alfa
{
	public partial class Detalhes : ContentPage
	{
		public Anuncio anuncio { get; set; }
		public Detalhes(Anuncio anuncio)
		{
			this.anuncio = anuncio;
			BindingContext = this;
			InitializeComponent();
		}
	}
}
