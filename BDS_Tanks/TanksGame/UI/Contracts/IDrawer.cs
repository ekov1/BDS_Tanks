﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TanksGame.Contracts;

namespace TanksGame.UI
{
    public interface IDrawer
    {
        void Draw(IDrawable obj);
        void Draw(IEnumerable<IDrawable> items);
    }
}
