using GameDemo.Abstract;
using GameDemo.Entites;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Concrete
{
    internal class GameSaleManager : IGameSale
    {
        public bool RetreveGame(Game game, Gamer gamer)
        {
            Console.WriteLine($"{game.Name} retreved from {gamer.FirstName}");
            return true;
        }

        public bool SaleGame(Game game, Gamer gamer)
        {
            Console.WriteLine($"{game.Name} sold to {gamer.FirstName}");
            return true;
        }
    }
}