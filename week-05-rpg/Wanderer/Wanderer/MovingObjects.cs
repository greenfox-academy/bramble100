﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wanderer
{
    class MovingObjects
    {
        Hero hero;
        List<Monster> monsters = new List<Monster>();
        private int totalNumberOfMonsters;
        private int level;

        private Dice dice;

        public MovingObjects(int totalNumberOfMonsters, int level, Dice dice)
        {
            this.totalNumberOfMonsters = totalNumberOfMonsters;
            this.level = level;
            this.dice = dice;

            hero = new Hero(dice);
            monsters.Add(new MonsterBoss(level, dice));
            monsters.Add(new KeyHolderMonster(level, dice));
            for (int i = 2; i < totalNumberOfMonsters; i++)
            {
                monsters.Add(new Monster(level, dice));
            }
        }
    }
}