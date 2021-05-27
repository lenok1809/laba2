using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace laba_2.Models
{
    public class Genre
    {
        public Genre()
        {
            Films = new List<Film>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Film> Films { get; set; }
    }
}
