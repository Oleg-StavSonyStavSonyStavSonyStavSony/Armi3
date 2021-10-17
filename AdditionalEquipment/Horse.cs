using System;
using System.Collections.Generic;
using System.Text;

namespace AdditionalEquipment
{
    public class Horse
    {
        public int DefendHP { get; set; }
        protected int Size { get; set; } = 1;

        public Horse(int defnd)
        {
            this.DefendHP = defnd;
        }

        public void Defend(Soldiers.Soldier holder, int damage)
        {
            holder.HP -= (damage - (this.DefendHP / Size));
        }

    }
}

    

