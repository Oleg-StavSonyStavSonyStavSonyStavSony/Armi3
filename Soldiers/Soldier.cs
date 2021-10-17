namespace Soldiers{
   // using Shields;
    using Weapon;
    public abstract class Soldier {
        public string Name { get; set; }
        public int HP { get; set; }
        public WeaponAbstruct Weapon { get; set; }
        public Shields.ShieldAbstruct ShieldAbstruct { get; set; }
        public AdditionalEquipment.ArmorAbstruct ArmorAbstruct {get; set;}
        public AdditionalEquipment.Horse Horse { get; set; }
        
        
        
        private Soldier(){}
        protected  Soldier(string name, int hp, WeaponAbstruct weapon) {
            this.Weapon = weapon;
            this.Name = name;
            this.HP = hp;
        }
        protected  Soldier(string name, int hp, WeaponAbstruct weapon, Shields.ShieldAbstruct shieldAbstruct) {
            this.Weapon = weapon;
            this.Name = name;
            this.HP = hp;
            this.ShieldAbstruct = shieldAbstruct;
        }
        protected Soldier(string name, int hp, WeaponAbstruct weapon, Shields.ShieldAbstruct shieldAbstruct, AdditionalEquipment.ArmorAbstruct armorAbstruct)
        {
            this.Weapon = weapon;
            this.Name = name;
            this.HP = hp;
            this.ShieldAbstruct = shieldAbstruct;
            this.ArmorAbstruct = armorAbstruct;
        }
        protected Soldier(string name, int hp, WeaponAbstruct weapon, Shields.ShieldAbstruct shieldAbstruct, AdditionalEquipment.ArmorAbstruct armorAbstruct, AdditionalEquipment.Horse horse)
        {
            this.Weapon = weapon;
            this.Name = name;
            this.HP = hp;
            this.ShieldAbstruct = shieldAbstruct;
            this.ArmorAbstruct = armorAbstruct;
            this.Horse = horse;
        }

        public  abstract void Atack(Soldier enemy);
        public  abstract void Defend(Soldier enemy);

        public override string ToString()
        {
            return $"{this.Name} has {this.HP} hp and send {this.Weapon.Damage} dm!";
        }

    }
}