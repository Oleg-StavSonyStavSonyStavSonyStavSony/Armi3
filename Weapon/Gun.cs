

namespace Weapon
{
   public  class Gun : WeaponAbstruct
    {

        public Core Core { get; set; } = new Core(20);
        public Gun ( ) : base(35)
            {
                
            }

    }
}
