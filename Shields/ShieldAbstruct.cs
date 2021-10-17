namespace Shields{
    public class ShieldAbstruct : IShields
    {
        public int DefendHP { get; set; }
        protected int Size { get; set; } = 1;

        public ShieldAbstruct(int defnd)
        {
           this.DefendHP = defnd;
        }
        
        public  void Defend(Soldiers.Soldier holder, int damage){
            holder.HP -= (damage - (this.DefendHP / Size));
        }

    }
}