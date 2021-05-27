using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace laba_2.Models
{
    public class Actor
    {
        public Actor()
        {
            FilmActors = new List<FilmActor>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Info { get; set; }


        public virtual ICollection<FilmActor> FilmActors { get; set; }
    }
}
