﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._12_OOP_GameBuildAlong
{
    public abstract class Character
    {
        //Constants - should always be in capital letters
        const int MIN_HEALTH = 0;

        //Properties
        public string Name { get; set; }
        public bool IsAlive { get; set; }
        public int Level { get; set; }
        public int Health { get; set; }
        public int AttackPower { get; set; }
        public int Energy { get; set; }
        public double CritChance { get; set; }

        //Methods
        public int Attack()
        {
            Random rnd = new Random();
            int spread = rnd.Next(-5, 6);
            int damage = this.AttackPower + spread;
            bool isCrit = IsCritical();
            return isCrit ? damage*2 : damage;
            //returns double damage if isCrit is true
        }

        public bool IsCritical()
        {
            Random rnd = new Random();
            bool isCrit = rnd.Next(0, 101) < (this.CritChance * 100) ? true : false;
            return isCrit;
        }
    }
}
