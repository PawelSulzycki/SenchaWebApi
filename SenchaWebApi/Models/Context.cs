using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SenchaWebApi.Models
{
    public class Context : DbContext
    {
        public Context() : base("Sencha") { }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Visitor> Visitors { get; set; }
    }
}