﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pawnShop.Models
{
    [Serializable]
    public abstract class User
    {
        public string Name { set; get; }
        public string Password { set; get; }
    }
}
