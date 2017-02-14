using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SenchaWebApi.Models
{
    public class Visitor
    {
        public int Id { get; set; }

        [Required, StringLength(100)]
        public String Name { get; set; }

        [Required, StringLength(100)]
        public String Surname { get; set; }

        [Required, StringLength(30)]
        public String Email { get; set; }

        public int? ReservationId { get; set; }

        [ForeignKey("ReservationId")]
        public virtual Reservation Reservations { get; set; }

        public string Address { get; set; }
        public string PhoneNumer { get; set; }
    }
}