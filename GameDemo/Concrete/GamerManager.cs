using GameDemo.Abstract;
using GameDemo.Entites;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Concrete
{
    public class GamerManager : ICustomerService
    {
        public bool Add(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " Added to database");
            return true;
        }

        public bool ChangeFirstName(Gamer gamer, string newName)
        {
            gamer.FirstName = newName;
            return true;
        }

        public bool ChangeLastName(Gamer gamer, string newLastName)
        {
            gamer.LastName = newLastName;
            return true;
        }

        public bool DeleteGamer(int gamerId)
        {
            Console.WriteLine("The player with:" + gamerId + " had been deleted");
            return true;
        }
    }
}