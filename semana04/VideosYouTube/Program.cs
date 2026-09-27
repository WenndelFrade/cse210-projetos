using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Olá, Mundo! Este é o Projeto VideosYouTube.");
    

    
        Video video1 = new Video ("Confiança na presença de Deus", "Russel M Nelson", 719);

        Comentario comentario1 = new Comentario("João", "Excelente tópico");
        Comentario comentario2 = new Comentario("Pedro", "Discurso inspirador");
        Comentario comentario3 = new Comentario("Lucas", "Está é Igreja verdadeira de Cristo");

        video1.novosComentarios(comentario1);
        video1.novosComentarios(comentario2);
        video1.novosComentarios(comentario3);


        Video video2 = new Video ("Vencer o mundo e encontrar descanso", "Russel M Nelson", 1123);

        Comentario comentario4 = new Comentario("Maria", "Excelente tópico");
        Comentario comentario5 = new Comentario("Marta", "Discurso inspirador");
        Comentario comentario6 = new Comentario("Sara", "Está é Igreja verdadeira de Cristo");

        video2.novosComentarios(comentario4);
        video2.novosComentarios(comentario5);
        video2.novosComentarios(comentario6);

        Video video3 = new Video ("Fé, Liberdade e o bem comum", "Dallin H Oaks", 1389);

        Comentario comentario7 = new Comentario("Maria", "Excelente tópico");
        Comentario comentario8 = new Comentario("Marta", "Discurso inspirador");
        Comentario comentario9 = new Comentario("Sara", "Está é Igreja verdadeira de Cristo");

        video3.novosComentarios(comentario7);
        video3.novosComentarios(comentario8);
        video3.novosComentarios(comentario9);


        List<Video> relacaoVideos = new List<Video>{video1, video2, video3};

        foreach (Video video in relacaoVideos)
        {
            Console.WriteLine($"Titulo: {video.ObterTitulo()}");
            Console.WriteLine($"Autor: {video.ObterAutor()}");
            Console.WriteLine($"Duração: {video.ObterDuracao()} segundos");
            Console.WriteLine($"Total de Comentários: {video.ObterQuantidadeComentario()}");
            Console.WriteLine($"Comentarios: ");
        
        
        
            foreach (Comentario comentario in video.ObterComentarios())
            {
                Console.WriteLine($"{comentario.ObterNomePessoa()}: {comentario.ObterTexto()}");
            }

    }
}
}