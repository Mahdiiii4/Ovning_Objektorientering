namespace Övning_Objektorientering
{
    public class Sorcerer : Character
    {
        private int mana;
        public Sorcerer(string name, int hp, int mana):base(name, hp)
        {
            this.mana = mana;
        }

        public int Mana
        {
            get { return mana; }
            set { mana = value;}
        }

        public override void Print()
        {
            Console.WriteLine("Namn: " + name);
            Console.WriteLine("Hp: " + hp);
            Console.WriteLine("Mana: " + mana);
        }
        public override void TakeDamage()
        {
            hp = hp-20;
        }
    }
}