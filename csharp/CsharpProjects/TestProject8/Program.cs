Random dice = new Random();

int attacks;
int heroHealth = 10;
int monsterHealth = 10;

do
{
    attacks = dice.Next(1, 11);
    monsterHealth -= attacks;

    Console.WriteLine($"Mosnter was damaged and lost {attacks} health and now has {monsterHealth} health.");
    
    if (monsterHealth <= 0) continue;

    attacks = dice.Next(1, 11);
    heroHealth -= attacks;

    Console.WriteLine($"Hero was damaged and lost {attacks} health and now has {heroHealth} health.");

} while (heroHealth > 0 && monsterHealth > 0);

Console.WriteLine(heroHealth > monsterHealth ? "Hero wins!" : "Hero loses :(");