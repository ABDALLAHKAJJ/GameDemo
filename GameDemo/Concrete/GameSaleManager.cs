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

        public bool SaleGame(Game game, Gamer gamer, params Campaign[] campaign)
        {
            Console.WriteLine($"{game.Name} sold to {gamer.FirstName}" +
                (campaign.Length > 0 ? $", and {campaign[0].Name} added " : )); ;
            return true;
        }

        public bool SaleGame(Game game, Gamer gamer, params ICampaign[] campaign)
        {
            throw new NotImplementedException();
        }
    }
}