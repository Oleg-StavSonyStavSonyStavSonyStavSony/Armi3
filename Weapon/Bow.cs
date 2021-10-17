

namespace Weapon
{
    public class Bow : WeaponAbstruct
    {
        public int BowArrows { get; set; }

        public Bow() : base(13)
        {
            this.BowArrows = 15;
        }

    }
}
