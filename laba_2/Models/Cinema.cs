using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace laba_2.Models
{
    public class Cinema
    {
        public Cinema()
        {
            Sessions = new List<Session>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Number { get; set; }

        public virtual ICollection<Session> Sessions { get; set; }
    }
}
