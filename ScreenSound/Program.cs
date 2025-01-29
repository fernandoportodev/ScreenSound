Album albumBaroes = new Album("Barões da Pisadinha");

Banda banda = new Banda("Barões da Pisadinha");
banda.AdicionarAlbum(albumBaroes);
banda.ExibirDiscografia();

Musica musica1 = new("Ta rocheda", banda, 180, true);

Musica musica2 = new("Nunca vai ser eu", banda, 240, false);

albumBaroes.AdicionarMusica(musica1);
albumBaroes.AdicionarMusica(musica2);

/************************************************************************************************************/

Podcast podcast = new("Fernando", "PortoDev");
Episodio episodio1 = new(2, "Técnicas de .ASP NET Core", 45);
episodio1.AdicionarConvidados("Julio");
episodio1.AdicionarConvidados("Junior");
episodio1.AdicionarConvidados("Cleyton");

Episodio episodio2 = new(3, "Técnicas de aprendizado", 45);
episodio2.AdicionarConvidados("Julia");
episodio2.AdicionarConvidados("Eva");
episodio2.AdicionarConvidados("Ravenna");

Episodio episodio3 = new(1, "Técnicas de C#", 45);
episodio3.AdicionarConvidados("Leo");
episodio3.AdicionarConvidados("Odim");
episodio3.AdicionarConvidados("Brage");

podcast.AdicionarEpisodio(episodio1);
podcast.AdicionarEpisodio(episodio2);
podcast.AdicionarEpisodio(episodio3);
podcast.ExibirDetalhes();

