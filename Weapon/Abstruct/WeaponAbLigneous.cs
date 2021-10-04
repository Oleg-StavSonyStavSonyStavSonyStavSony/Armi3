namespace Weapon{
   public class WeaponAbLigneous : WeaponAbstruct{
        public int HP_Level { get; private set; }
       
        public int Damage { get; private set; }

        public int Lengths {get; private set; }  //длинна
       
        protected WeaponAbstruct(int damage)
        {
            this.HP_Level= 100;
            this.Damage = damage;
            this.Lengths = 50;
        }
        public int Hit(Soldier owner,Soldier enemy  ){
             owner.Defend(enemy);
             return --this.HP_Level;
        }

    }
}