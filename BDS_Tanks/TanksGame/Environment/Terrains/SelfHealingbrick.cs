﻿using System;
using TanksGame.Core.Enums;
using TanksGame.Core.Providers;

namespace TanksGame.Environment.Terrains
{
    public class SelfHealingbrick : Brick
    {
        private int health;

        public SelfHealingbrick(int startX, int startY)
            : base(startX, startY)
        {
            this.health = (int)HealthList.NormalBrickHealth;

        }

        // TODO:
        private void IncreaseHealth()
        {
            // if(time > condition)
            // health +++
        }

        public override Texture Texture
        {
            get
            {
                return new Texture(BoolTemplateProvider.Instace.GetBoolTemplate("terrain"), '§', ConsoleColor.Red); ;
            }
        }
    }
}