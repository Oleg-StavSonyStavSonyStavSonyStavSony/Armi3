namespace Weapon{
    using Soldiers;
   public class WeaponAbFar : WeaponAbstruct{
        public int HP_Level { get; private set; }
       
        public int Damage { get; private set; }

        public int Projectile {get; private set; } //снаряд
       
        protected WeaponAbstruct(int damage)
        {
            this.HP_Level= 100;
            this.Damage = damage;
            this.Projectile = 25;
        }
        public int Hit(Soldier owner,Soldier enemy  ){
             owner.Defend(enemy);
             return --this.HP_Level;
        }

    }
}