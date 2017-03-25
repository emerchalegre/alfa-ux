using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace App02Alfa
{
	public partial class Pagina2 : ContentPage
	{
		public Pagina2()
		{
			InitializeComponent();
		}

		void Handle_Clicked(object sender, System.EventArgs e)
		{
			Navigation.PopAsync();

			//Navigation.PopToRootAsync();
		}
	}
}
