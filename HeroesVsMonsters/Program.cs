// See https://aka.ms/new-console-template for more information
using HeroesVsMonsters.Models;

Console.WriteLine("Hello, World!");
Wolf w = new Wolf();
w.SpawnLeather();
Console.WriteLine(w.Leather);

Human human = new Human();
human.SetStrenght(Human.Dice6());
human.SetEndurance(Human.Dice6());
human.SetHp();
human.Attack();
Console.WriteLine($"HP : {human.Hp}");
Console.WriteLine($"Force : {human.Strenght}");
Console.WriteLine($"Endurance : {human.Endurance}");
Console.WriteLine($"ATK : {human.ATK}");
