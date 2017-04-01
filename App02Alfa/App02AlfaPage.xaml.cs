using Xamarin.Forms;

namespace App02Alfa
{
	public partial class App02AlfaPage : ContentPage
	{
		public string Email { get; set; }
		public string Senha { get; set; }
		public Command CmdNavegar { get; set; }
		public Command CmdOpenWs { get; set; }

		public App02AlfaPage()
		{
			if (Device.OS == TargetPlatform.iOS) {
				Padding = new Thickness(0, 20, 0, 0);
			}

			Padding = Device.OnPlatform(new Thickness(20), new Thickness(20), new Thickness(0));

			InitializeComponent();

			lbl.Text = "Aula de UX";

			Email = "emerchalegre@gmail.com";
			CmdNavegar = new Command(Navegar);
			CmdOpenWs = new Command(OpenWs);

			BindingContext = this;

		}

		void OpenWs()
		{
			Navigation.PushAsync(new Anuncios());
		}

		void Navegar()
		{
			Navigation.PushAsync(new Pagina2());
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
