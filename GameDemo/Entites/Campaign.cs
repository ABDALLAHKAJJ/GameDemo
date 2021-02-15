using GameDemo.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Entites
{
    internal class Campaign : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Details { get; set; }
    }
}