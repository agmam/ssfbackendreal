using SSFSalmonApp.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SSFSalmonApp.DAL
{
    public class InitializeDb : DropCreateDatabaseAlways<SSFContext>
    {
        protected override void Seed(SSFContext context)
        {
            List<Fish> Fishes = new List<Fish>();
            List<User> Users = new List<User>();
            int i = 0;
            User Esben = new User()
            {
                Id = 1,
                Email = "Esben.laursen@gmail.com",
                FishList = null,
                Name = "Esben",
                Password = "lol123",
                PhoneNr = "324940283"
            };
            User Emil = new User()
            {
                Id = 2,
                Email = "Emilogefternavnmor@gmail.com",
                FishList = null,
                Name = "Emil",
                Password = "lol123",
                PhoneNr = "314242342"
            };
            Users.Add(Esben);
            Users.Add(Emil);

            Fish f = new Fish()
            {
                id = 1,
                Type = "Salmon",
                Bait = "Flyfishing",
                CaughtByUser = Esben,
                DayCaught = DateTime.Now,
                Length = 50.0,
                Location = "Bathroom",
                Weight = 20.0
            };
            Fish f2 = new Fish()
            {
                id = 1,
                Type = "Trout",
                Bait = "Flyfishing",
                CaughtByUser = Emil,
                DayCaught = DateTime.Now.AddDays(-3),
                Length = 100.0,
                Location = "In toilet",
                Weight = 5.0
            };
            Fishes.Add(f);
            Fishes.Add(f2);

            foreach (User u in Users)
            {
                context.Users.Add(u);
            }
            foreach (Fish fish in Fishes)
            {
                context.Fishes.Add(fish);
            }

            context.SaveChanges();

        }
    }
}