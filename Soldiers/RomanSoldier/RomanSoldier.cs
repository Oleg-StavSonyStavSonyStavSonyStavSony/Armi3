namespace Soldiers{
     using Weapon;
    public class RomanSoldier : Soldier{
        public RomanSoldier(string name) : base (name, 100, new Bastard(),new Shields.SmallShield()){

        }

        public  override void Atack(Soldier enemy){
          this.Weapon.Hit(this, enemy);
          this.Weapon.Hit(this, enemy);
        }
        public  override void Defend(Soldier enemy){
            this.ShieldAbstruct?.Defend(this, enemy.Weapon.Damage);

        }
    }
}