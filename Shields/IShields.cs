using System;
using System.Collections.Generic;
using System.Text;

namespace Shields
{
    interface IShields
    {
        public void Defend(Soldiers.Soldier holder, int damage);
    }
        
}
