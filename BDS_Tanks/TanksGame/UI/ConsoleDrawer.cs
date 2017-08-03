﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TanksGame.UI
{
    public class ConsoleDrawer : IDrawer
    {
        public ConsoleDrawer()
        {
            Console.CursorVisible = false;
            Console.WriteLine("{0} {1}", Console.LargestWindowWidth, Console.LargestWindowHeight);
            Console.SetWindowSize(Console.LargestWindowWidth, Console.LargestWindowHeight);
            Console.SetBufferSize(Console.LargestWindowWidth, Console.LargestWindowHeight);
        }

        public void Draw(IDrawable obj)
        {
            var body = obj.UnitBody.Body;
            Console.ForegroundColor = obj.UnitBody.Color;
            int cursorX = obj.X;
            int cursorY = obj.Y;

            for (int i = 0; i < body.Count(); i++)
            {
                Console.SetCursorPosition(cursorX, cursorY);
                foreach (bool bit in body[i])
                {
                    Console.Write(bit ? obj.UnitBody.Fill : ' ');
                }
                
                cursorY++;
                Console.WriteLine();
            }
        }
    }
}
