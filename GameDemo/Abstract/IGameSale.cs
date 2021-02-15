using GameDemo.Entites;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Abstract
{
    public interface IGameSale
    {
        bool SaleGame(Game game, Gamer gamer, params Campaign[] campaign);

        bool RetreveGame(Game game, Gamer gamer);
    }
}