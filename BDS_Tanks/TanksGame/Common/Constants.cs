namespace TanksGame.Common
{
    public static class Constants
    {
        public const int TankSpeed = 2;

        public const int PlayerStartX = ConsoleWidth/2 - PlayerWidth;
        public const int PlayerStartY = 25;
        
        public const int SecondPlayerStartX = (ConsoleWidth - 25) - PlayerWidth;
        public const int SecondPlayerStartY = 5;
        
        public const int ConsoleHeight = 40;
        public const int ConsoleWidth = 40;

        public const int PlayerHeight = 3;
        public const int PlayerWidth = 5;

        public const int TerrainHeight = 4;
        public const int TerrainWidth = 4;

        public const int ThreadSleep = 10;
        public const int TerrainCountOnMap = 15;

        public const int MachineGunDamage = 1;
        public const int RocketDamage = 10;
        public const int BulletWithButterflyWingsDamage = 3;

        public const char WaterTerrain = '~';
        public const char BrickTerrain = 'E';
        public const char StoneTerrain = 'X';
    }
}