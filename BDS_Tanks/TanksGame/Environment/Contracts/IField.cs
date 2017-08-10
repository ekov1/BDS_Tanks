﻿using System.Collections.Generic;

namespace TanksGame.Environment.Contracts
{
    public interface IField
    {
        IEnumerable<bool> OccupiedFields { get; }

        void OccupyField(int offsetX, int offsetY);

        void UnOccupyField(int offsetX, int offsetY);
    }
}