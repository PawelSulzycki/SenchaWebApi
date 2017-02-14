using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
using Antlr.Runtime.Tree;

namespace SenchaWebApi.Models
{
    [DataContract]
    public class Reservation
    {
        [DataMember(Name = "id")]
        public int Id { get; set; }

        [DataMember(Name = "codeReservation")]
        [Required, StringLength(10)]
        public string CodeReservation { get; set; }

        [DataMember(Name = "creationDate")]
        public DateTime CreationDate { get; set; }

        [DataMember(Name = "price")]
        public decimal Price { get; set; }

        [DataMember(Name = "checkInDate")]
        public DateTime? CheckInDate { get; set; }

        [DataMember(Name = "chcekOutDate")]
        public DateTime? ChcekOutDate { get; set; }

        [DataMember(Name = "comission")]
        public decimal? Commission { get; set; }

        public virtual IList<Visitor> Visitors { get; set; }
    }
}