using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace laba_2.Models
{
    public class LabCinemaContext :DbContext
    {
        public virtual DbSet<Cinema> Cinemas{get;set;}
        public virtual DbSet<Session> Sessions { get; set; }
        public virtual DbSet<Film> Films { get; set; }
        public virtual DbSet<Genre> Genres { get; set; }
        public virtual DbSet<Actor> Actors { get; set; }
        public virtual DbSet<FilmActor> FilmActors { get; set; }

        public LabCinemaContext(DbContextOptions<LabCinemaContext> options)
            : base (options)
        {
            Database.EnsureCreated();
        }


    }
}
