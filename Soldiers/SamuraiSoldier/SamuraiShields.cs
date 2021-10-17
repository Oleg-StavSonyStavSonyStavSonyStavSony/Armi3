
namespace Soldiers
{
    using Weapon;
    using System;
    
    public class SamuraiShields : Soldier
    { 
    protected System.Random r;
    public SamuraiShields(string name) : base(name, 70, new Katana(), new Shields.BigShield()) { this.r = new System.Random(); }

        public override void Atack(Soldier enemy)
    {
        this.Weapon.Hit(this, enemy);
    }
    public override void Defend(Soldier enemy)
    {
        System.Console.WriteLine($"Text");
        var a = r.Next(0, enemy.Weapon.Damage);
        System.Console.WriteLine($"{a}");

        this.HP -= (enemy.Weapon.Damage - a);
    }
}
}