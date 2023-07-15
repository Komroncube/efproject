



namespace efproject.model
{
    public class Actor
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string MostPopularFilm { get; set; }
        public DateTimeOffset LastUpdate { get; set; }
    }
}
