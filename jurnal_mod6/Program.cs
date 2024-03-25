namespace jurnal_mod6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SayaTubeUser user = new SayaTubeUser("Wildan");
            SayaTubeVideo video = new SayaTubeVideo("Review Film Interstellar oleh Wildan");
            user.AddVideo(video);
            video = new SayaTubeVideo("Review Film Habibie dan Ainun 1 oleh Wildan");
            user.AddVideo(video);
            video = new SayaTubeVideo("Review Film Habibie dan Ainun 2 oleh Wildan");
            user.AddVideo(video);
            video = new SayaTubeVideo("Review Film Habibie dan Ainun 3 oleh Wildan");
            user.AddVideo(video);
            video = new SayaTubeVideo("Review Film Habibie dan Ainun 4 oleh Wildan");
            user.AddVideo(video);
            video = new SayaTubeVideo("Review Film Habibie dan Ainun 5 oleh Wildan");
            user.AddVideo(video);
            video = new SayaTubeVideo("Review Film Habibie dan Ainun 6 oleh Wildan");
            user.AddVideo(video);
            video = new SayaTubeVideo("Review Film Habibie dan Ainun 7 oleh Wildan");
            user.AddVideo(video);
            video = new SayaTubeVideo("Review Film Habibie dan Ainun 7 oleh Wildan");
            user.AddVideo(video);
            video = new SayaTubeVideo("Review Film Habibie dan Ainun 8 oleh Wildan");
            user.AddVideo(video);
            user.PrintAllVideoPlaycount();

        }
    }
}
