﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wanderer
{
    class MonsterBoss : Monster
    {
        internal MonsterBoss(int level, Dice dice) : base(dice)
        {
            InitalizePoints();
        }

        internal override void InitalizePoints()
        {
            // Monster Lvl x(if boss)
            // HP: 2 * x * d6(+d6)
            MaximalHealthPoints = CurrentHealthPoints = 2 * level * dice.Roll() + dice.Roll();
            // DP: x / 2 * d6(+d6 / 2)
            DefendPoints = level / 2 * dice.Roll() + dice.Roll() + dice.Roll() / 2;
            // SP: x* d6(+x)
            StrikePoints = level * dice.Roll() + level;
        }

    }
}
