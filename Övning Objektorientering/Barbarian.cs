namespace Övning_Objektorientering
{
    public class Barbarian : Character
    {
        private int rageLevel;
        public Barbarian(string name, int hp, int rageLevel):base(name, hp)
        {
            this.rageLevel= rageLevel;
        }

        public int RageLevel
        {
            get { return rageLevel; }
            set { rageLevel = value; }
        }

        public override void Print()
        {
            Console.WriteLine("Namn: " + name);
            Console.WriteLine("Hp: " + hp);
            Console.WriteLine("RageLevel: " + rageLevel);
        }
        public override void TakeDamage()
        {
            hp = hp-5;
        }
    }
}