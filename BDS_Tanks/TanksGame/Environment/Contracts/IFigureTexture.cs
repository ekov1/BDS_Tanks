using System;

namespace TanksGame.Environment.Contracts
{
    public interface IFigureTexture : ITexture
    {
        char Symbol { get; set; }

        ConsoleColor Color { get; set; }
    }
}