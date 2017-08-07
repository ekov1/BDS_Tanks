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
            var body = obj.Texture.Body;
            Console.ForegroundColor = obj.Texture.Color;
            int cursorX = obj.X;
            int cursorY = obj.Y;

           foreach(var line in body)
            {
                Console.SetCursorPosition(cursorX, cursorY);
                foreach (bool bit in line)
                {
                    Console.Write(bit ? obj.Texture.Symbol : ' ');
                }
                
                cursorY++;
                Console.WriteLine();
            }
        }
    }
}