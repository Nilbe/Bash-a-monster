Knight aKnight = new Knight();
Dragon aDragon = new Dragon();


while(aDragon.HP > 0)
{
Console.WriteLine(aKnight.name + " has " + aKnight.HP + " HP");
Console.WriteLine(aDragon.name + " has " + aDragon.HP + " HP");
Console.WriteLine("press ENTER to attack the dragon");

Console.ReadLine();

aDragon.HP -= aKnight.DMG;
}
if(aDragon.HP <= 0 )
{
    Console.WriteLine("HURRAY! You have slayed the dragon");
}

Console.ReadLine();