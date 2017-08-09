﻿namespace TanksGame.Common
{
    public static class Constants
    {
        public const int PlayerStartX = ConsoleWidth/2 - PlayerWidth;
        public const int PlayerStartY = 40;


        public const int ConsoleWidth = 50;
        public const int ConsoleHeight = 50;

        public const int PlayerHeight = 3;
        public const int PlayerWidth = 5;

        public const int TerrainWidth = 5;
        public const int TerrainHeight = 3;

        public const int ThreadSleep = 10;
        public const int TerrainCountOnMap = 15;
        
        public const char WaterTerrain = '~';
        public const char BrickTerrain = 'E';
        public const char StoneTerrain = 'X';

    }
}
