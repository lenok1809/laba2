using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace laba_2.Models
{
    public class Film
    {
        public Film()
        {
            Sessions = new List<Session>();
            FilmActors = new List<FilmActor>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int GenreId { get; set; }
        public string Director { get; set; }
        public int Minutes { get; set; }
        public decimal Value { get; set; }
        public string StudioName { get; set; }
        public virtual Genre Genre { get; set; }
        

        public virtual ICollection<Session> Sessions { get; set; }
        public virtual ICollection<FilmActor> FilmActors { get; set; }
    }
}
