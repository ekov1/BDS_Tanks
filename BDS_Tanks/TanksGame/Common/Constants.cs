namespace TanksGame.Common
{
    public static class Constants
    {
        public const int PlayerStartX = ConsoleWidth/2 - PlayerWith;
        public const int PlayerStartY = 40;


        public const int ConsoleWidth = 100;
        public const int ConsoleHeight = 50;

        public const int PlayerWidth = 4;
        public const int PlayerWith = 5;

        public const int TerrainWidth = 5;
        public const int TerrainHeight = 3;

        public const int ThreadSleep = 10;
        public const int TerrainCountOnMap = 15;
        
        public const char WaterTerrain = '~';
        public const char BrickTerrain = 'E';
        public const char StoneTerrain = 'X';

    }
}
