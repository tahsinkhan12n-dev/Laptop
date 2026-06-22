Random dice = new();
int roll = dice.Next(1, 7);
int roll_2 = dice.Next(1, 7);
int roll_3 = dice.Next(1, 7);

int bonus = 0;

if (roll == roll_2 || roll == roll_3 || roll_2 == roll_3)
{
    bonus = bonus + 2;
}

if ( roll == roll_2 == roll_3)
{
    bonus = bonus + 6;
}

if (roll + roll_2 + roll_3 + bonus >= 15)
{
    Console.WriteLine("You win!");
}
if (roll + roll_2 + roll_3 + bonus < 15)
{
    Console.WriteLine("You lose");
}
