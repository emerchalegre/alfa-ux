using System;

using Xamarin.Forms;

namespace App02Alfa
{
	public class Pagina3 : ContentPage
	{
		public Pagina3()
		{
			Content = new StackLayout
			{
				Children = {
					new Label { Text = "Hello ContentPage" }
				}
			};
		}
	}
}

