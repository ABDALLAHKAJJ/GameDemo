using GameDemo.Entites;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Abstract
{
    public interface IGamerCheckService
    {
        bool ChechIfRealPerson(Gamer gamer);
    }
}