using System;
using Övning_Objektorientering;

Paladin minPaladin = new Paladin("Paladin", 200, 100);
Sorcerer minSorcerer = new Sorcerer("Sorcerer", 200, 150);
Barbarian minBarbarian = new Barbarian("Barbarian", 200, 300);

List<Character> Objects = new List<Character>();

Objects.Add(minPaladin);
Objects.Add(minSorcerer);
Objects.Add(minBarbarian);


for(int i = 0; i < 2; i++)
{
    foreach(Character klass in Objects)
    {
        klass.TakeDamage();
    }
    foreach(Character klass in Objects)
    {
        Console.WriteLine(klass.Name + " blev skadad!");
        klass.Print();
    }
}