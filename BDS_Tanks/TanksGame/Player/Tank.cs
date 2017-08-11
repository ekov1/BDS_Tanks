using System;
using System.Collections.Generic;
using System.Media;
using System.Speech.Synthesis;
using System.Threading.Tasks;
using TanksGame.Common;
using TanksGame.Contracts;
using TanksGame.Core.Enums;
using TanksGame.Environment;
using TanksGame.Environment.Contracts;
using TanksGame.Projectiles;
using TanksGame.UI.Contracts;

namespace TanksGame.Player
{
    public class Tank : ITank, IMovable, IDrawable
    {
        private string name;
        public Tank(int x, int y, IFigureTexture texture)
        {
            this.X = x;
            this.Y = y;
            this.FigureTexture = texture;
            this.WeaponType = ProjectileType.MachineGun;
            this.FiredProjectiles = new List<IProjectile>();
        }


        public IFigureTexture FigureTexture { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public ProjectileType WeaponType { get; set; }

        public ICollection<IProjectile> FiredProjectiles { get; protected set; }

        public string Name
        {
            get
            {
                return this.name;
            }
        }

        public bool DefenseMode
        {
            get
            {
                throw new NotImplementedException();
            }
        }


        public void Attack()
        {

        }

        public async static void Report()
        {
            int number;
            Random rng = new Random();
            number = rng.Next(0, 13);
            SoundPlayer sp = new SoundPlayer();

            switch (number)
            {
                case 1:
                    sp.SoundLocation = "../../tankSounds/1.wav";
                    break;
                case 2:
                    sp.SoundLocation = "../../tankSounds/2.wav";
                    break;
                case 3:
                    sp.SoundLocation = "../../tankSounds/3.wav";
                    break;
                case 4:
                    sp.SoundLocation = "../../tankSounds/4.wav";
                    break;
                case 5:
                    sp.SoundLocation = "../../tankSounds/5.wav";
                    break;
                case 6:
                    sp.SoundLocation = "../../tankSounds/6.wav";
                    break;
                case 7:
                    sp.SoundLocation = "../../tankSounds/7.wav";
                    break;
                case 8:
                    sp.SoundLocation = "../../tankSounds/8.wav";
                    break;
                case 9:
                    sp.SoundLocation = "../../tankSounds/9.wav";
                    break;
                case 10:
                    sp.SoundLocation = "../../tankSounds/10.wav";
                    break;
                case 11:
                    sp.SoundLocation = "../../tankSounds/11.wav";
                    break;
                case 12:
                    sp.SoundLocation = "../../tankSounds/12.wav";
                    break;
                case 13:
                    sp.SoundLocation = "../../tankSounds/13.wav";
                    break;
            }

            Action a = new Action(sp.PlaySync);

            await Task.Run(a);
        }

        public async static void ShootSound()
        {
            SoundPlayer sp = new SoundPlayer();
            sp.SoundLocation = "../../sfx/6.wav";

            Action a = new Action(sp.PlaySync);

            await Task.Run(a);
        }
    }
}
