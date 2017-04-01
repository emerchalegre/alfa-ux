using System;
namespace App02Alfa
{
	public class Anuncio
	{
		public string Imagem { get; set; }
		public int Id { get; set; }
		public string Titulo { get; set; }
		public string Valor { get; set; }

		public string Src => "https://classidiario.odiario.com/content/media/imagem/" + Imagem ;
	}
}
