using System;

string[] pettingZoo = 
{
    "alpacas", "capybaras", "chickens", "ducks", "emus", "geese", 
    "goats", "iguanas", "kangaroos", "lemurs", "llamas", "macaws", 
    "ostriches", "pigs", "ponies", "rabbits", "sheep", "tortoises",
};




// RandomizeAnimals();
 void RandomizeAnimals()
{
    Random random = new Random();

    for (int i = 0; i < pettingZoo.Length; i++)
    {
        int r = random.Next(i, pettingZoo.Length);

        string tmp = pettingZoo[i];
        pettingZoo[i] = pettingZoo[r];
        pettingZoo[r] = tmp;
    }
}

// AssignGroup();

Console.WriteLine("School A");
// PrintGroup(group);



