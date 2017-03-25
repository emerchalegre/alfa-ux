using Xamarin.Forms;

namespace App02Alfa
{
	public partial class App02AlfaPage : ContentPage
	{
		public App02AlfaPage()
		{
			if (Device.OS == TargetPlatform.iOS) {
				Padding = new Thickness(0, 20, 0, 0);
			}

			Padding = Device.OnPlatform(new Thickness(20), new Thickness(20), new Thickness(0));

			InitializeComponent();

			lbl.Text = "Aula de UX";
		}

		void Handle_Clicked(object sender, System.EventArgs e)
		{
			Navigation.PushAsync(new Pagina2());
		}

		void OpenPopup(object sender, System.EventArgs e)
		{
			Navigation.PushModalAsync(new Pagina3());
		}
	}
}
