using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace laba_2.Models
{
    public class Session
    {
        public int CinemaId { get; set; }
        public int FilmId { get; set; }
        public int Id { get; set; }
        [Display(Name = "Номер залу")]
        public int HallNumber { get; set; }
        [Display(Name = "Місце")]
        public int FreeSeat { get; set; }
        [Display(Name = "Дата та час")]
        public DateTime SDate { get; set; }
        [Display(Name = "Ціна")]
        public decimal Price { get; set; }
        public virtual Cinema Cinema { get; set; }
        public virtual Film Film { get; set; }
       



    }
}
