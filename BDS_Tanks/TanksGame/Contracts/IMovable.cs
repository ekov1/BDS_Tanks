﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TanksGame.Contracts
{
    public interface IMovable
    {
        int X { get; set; }
        
        int Y { get; set; }
    }
}
