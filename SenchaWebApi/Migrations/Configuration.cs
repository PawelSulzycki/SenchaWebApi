using SenchaWebApi.Models;

namespace SenchaWebApi.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<SenchaWebApi.Models.Context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(SenchaWebApi.Models.Context context)
        {
            context.Reservations.AddOrUpdate(x => x.Id,
                new Reservation() { Id = 1, CodeReservation = "19300", Price = 100, CreationDate = new DateTime(2017, 2, 2),CheckInDate = new DateTime(2017, 2, 3),ChcekOutDate = new DateTime(2017, 2, 13)},
                new Reservation() { Id = 2, CodeReservation = "19301", Price = 200, CreationDate = new DateTime(2017, 2, 12) }
                );

            context.Visitors.AddOrUpdate(x => x.Id,
                new Visitor() { Id = 1, Name = "Pawel", Surname = "Sulzycki", Email = "pawelsulzycki@gmail.com", ReservationId = 1 },
                new Visitor() { Id = 2, Name = "Przemek", Surname = "Sulzycki", Email = "przemeksulzycki@gmail.com", ReservationId = 2 },
                new Visitor() { Id = 3, Name = "Jacek", Surname = "Sulzycki", Email = "jaceksulzycki@gmail.com", ReservationId = 1 });

        }
    }
}
