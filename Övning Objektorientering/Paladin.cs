namespace Övning_Objektorientering
{
    public class Paladin : Character
    {
        private int holyPower;
        public Paladin(string name, int hp, int holyPower):base(name, hp)
        {
            this.holyPower = holyPower;
        }

        public int HolyPower
        {
            get { return holyPower; }
            set { holyPower = value; }
        }

        public override void Print()
        {
            Console.WriteLine("Namn: " + name);
            Console.WriteLine("Hp: " + hp);
            Console.WriteLine("HolyPower: " + holyPower);
        }
        public override void TakeDamage()
        {
            hp = hp-10;
        }
    }
}