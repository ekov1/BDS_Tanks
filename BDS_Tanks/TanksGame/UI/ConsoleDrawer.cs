using System;
using System.Collections.Generic;
using TanksGame.Common;
using TanksGame.UI.Contracts;

namespace TanksGame.UI
{
    public class ConsoleDrawer : IDrawer
    {
        public ConsoleDrawer()
        {
            Console.CursorVisible = false;
            //Console.WriteLine("{0} {1}", Console.LargestWindowWidth, Console.LargestWindowHeight);

            Console.SetWindowSize(Constants.ConsoleWidth, Constants.ConsoleHeight);
            Console.SetBufferSize(Constants.ConsoleWidth, Constants.ConsoleHeight);
        }

        public void Draw(IDrawable obj)
        {
            var body = obj.FigureTexture.Body;
            Console.ForegroundColor = obj.FigureTexture.Color;
            int cursorX = obj.X;
            int cursorY = obj.Y;

            foreach (var line in body)
            {
                Console.SetCursorPosition(cursorX, cursorY);

                foreach (bool bit in line)
                {
                    Console.Write(bit ? obj.FigureTexture.Symbol : ' ');
                }

                cursorY++;
                Console.WriteLine();
            }
        }

        public void Draw(IEnumerable<IDrawable> items)
        {
            foreach (IDrawable item in items)
            {
                this.Draw(item);
            }
        }
    }
}