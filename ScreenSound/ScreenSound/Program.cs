using System;

Banda nxzero = new Banda("nx zero");

Album albumdonx = new Album("norte");

Musica musica1 = new Musica(nxzero, "cedo ou tarde")
{
    Duracao = 210,
    Disponivel = true,
};

Musica musica2 = new Musica(nxzero, "só rezo")
{
    Duracao = 250,
    Disponivel = false,
};

albumdonx.AdicionarMusica(musica1);
albumdonx.AdicionarMusica(musica2);
nxzero.AdicionarAlbum(albumdonx);

musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();
albumdonx.ExibirMusicaAlbum();
nxzero.ExibirDiscografia();

Episodio ep1 = new (1, "Inspirações", 40);
ep1.AdicionarConvidados("Gee Rocha");
ep1.AdicionarConvidados("Di Ferreiro");

Episodio ep2 = new(2, "Acordes", 50);
ep2.AdicionarConvidados("Caco");
ep2.AdicionarConvidados("Dani");
Console.WriteLine(ep2.Resumo);

Podcast podcast = new("Nicolli", "Song Music");
podcast.AdicionarEpisodio(ep1);
podcast.AdicionarEpisodio(ep2);
podcast.ExibirDetalhes();