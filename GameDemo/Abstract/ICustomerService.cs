using GameDemo.Entites;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Abstract
{
    public interface ICustomerService
    {
        bool Add(Gamer gamer);
    }
}