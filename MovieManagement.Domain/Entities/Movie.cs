namespace MovieManagement.Domain.Entities
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;

        public int ActorId { get; set; } // in one movie there can be multple actors
        public Actor? Actor { get; set; } // also for that actor 

        public List<Genre>? Genres { get; set; } // in one movie there can be many genres
    }
}