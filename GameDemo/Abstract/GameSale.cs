﻿using GameDemo.Entites;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Abstract
{
    internal interface GameSale
    {
        bool SaleGame(Game game, Gamer gamer);

        bool RetreveGame(Game game, Gamer gamer);
    }
}