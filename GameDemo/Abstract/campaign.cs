﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Abstract
{
    public interface Campaign
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Details { get; set; }
    }
}