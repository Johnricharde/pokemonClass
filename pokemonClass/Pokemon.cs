namespace pokemonClass
{
    class Pokemon
    {
        public string Name;
        public int Lvl;
        public int Hp;

        public Pokemon(string newName, int newLvl, int newHp)
        {
            Name = newName;
            Lvl = newLvl;
            Hp = newHp;
        }

        public void showInfo()
        {
            Console.WriteLine($"Name: {Name}\nLevel: {Lvl}\nHealth: {Hp}");
        }
    }
}
