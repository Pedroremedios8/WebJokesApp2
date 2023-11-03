namespace WebJokesApp2.Models
{
    public class Jokes
    {
        public int Id { get; set; }
        public string JokePergunta { get; set; }
        public string JokesResposta { get; set; }

        public string IdUser { get; set; }

        public Jokes()
        {
                Id = 0;
            JokePergunta = string.Empty;
            JokePergunta = string.Empty;
            IdUser = string.Empty;
        }
    }
}
