
namespace efproject
{
    public static class TableService
    {
        public static void AddActor(string name, string film)
        {
            using (var db = new ActorDB())
            {
                var actor = new Actor()
                {
                    Name = name,
                    MostPopularFilm = film,
                    LastUpdate= DateTimeOffset.UtcNow,
                };
                db.Add(actor);
                db.SaveChanges();
            }
        }
        public static void RemoveActor(string name)
        {
            var db = new ActorDB();
            var actor = db.Actors.FirstOrDefault(actor => actor.Name.Equals(name));
            if (actor!= null)
            {
                db.Remove(actor);
                db.SaveChanges();
            }
        }
        public static void Update(string name, string film)
        {
            var db = new ActorDB();
            var actor = db.Actors.Where(actor => actor.Name.Equals(name)).ToList()[0];
            if (actor != null)
            {
                actor.MostPopularFilm=film;
                actor.LastUpdate= DateTimeOffset.UtcNow;
                db.SaveChanges();
            }
        }
        public static Actor GetActorByName(string name) 
        {
            var db = new ActorDB();
            var actor =db.Actors.FirstOrDefault(actor=>actor.Name.Equals(name));
            return actor;
        }
        public static List<Actor> GetActors()
        {
            var db = new ActorDB();
            var actors = db.Actors.ToList();
            return actors;
        }
    }
}
