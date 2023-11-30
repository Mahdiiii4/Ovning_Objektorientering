namespace Övning_Objektorientering
{
    public abstract class Character
    {
        protected String name;
        protected int hp;

        public Character(string name, int hp)
        {
            this.name = name;
            this.hp = hp;
        }

        public string Name
        {
            get { return name; }
            set { name = value;}
        }
        
        public int Hp
        {
            get { return hp; }
            set { hp = value;}
        }

        public abstract void Print();
        public abstract void TakeDamage();
    }
}