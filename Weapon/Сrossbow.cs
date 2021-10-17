

namespace Weapon
{
    class Сrossbow : WeaponAbstruct
    {
        public int СrossbowArrows { get; set; }

        public Сrossbow() : base(20)
        {
            this.СrossbowArrows = 10;
        }
    }
}
