﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._11_OOP_Game
{
    public abstract class Character
    {
        //constants
        const int Min_Health = 0;
        //properties
        public string Name { get; set; }
        public bool IsAlive { get; set; }
        public int Health { get; set; }
        public int AttackLevel { get; set; }
        public int Stamina { get; set; }
        public int Luck { get; set; }
        public int Level { get; set; }

    

        //methods
        public void GetPowerLevel()
        {
            Random rnd = new Random();
            int powerLevel = rnd.Next(1, 100);
            this.Level=powerLevel;
        }

        public int Attack(int attackLevel)
        {
            Random rnd = new Random();
            int damage = rnd.Next(1, attackLevel);
            return damage;
        }


    }
}
