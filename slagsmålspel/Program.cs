Console.WriteLine("Välkommen till mitt Slagsmålsspel!!!!!!!WOOPWOOOP");

int gregoryHP = 100;
int senkadenkaHP = 100;

string gregoryname = "gregory";
string senkadenkaname = "senkadenka";

Random Generator = new Random();

while (gregoryHP > 0 && senkadenkaHP > 0)
{
    Console.WriteLine("!!!NY RUNDA WOOOOP WOOOP!!!");
    Console.WriteLine($"{gregoryname}: {gregoryHP}  {senkadenkaname}: {senkadenkaHP}");

    int gregorydamage = Generator.Next(20);
    senkadenkaHP -= gregorydamage;
    senkadenkaHP = Math.Max(0, senkadenkaHP);
    Console.WriteLine($"{gregoryname} gör {gregorydamage} damage på {senkadenkaname}!!!");

    int senkadenkadamage = Generator.Next(20);
    gregoryHP -= senkadenkadamage;
    gregoryHP = Math.Max(0, gregoryHP);
    Console.WriteLine($"{senkadenkaname} gör {senkadenkadamage} damage på {gregoryname}!!!");

    Console.WriteLine("Tryck på valfri knapp för att fortsätta...");
    Console.ReadLine();
}

Console.WriteLine("!!!FIGHTEN ÄR SLUT WOOP WOOP!!!");

if (gregoryHP == 0 && senkadenkaHP ==- 0)
{
    Console.WriteLine("OAVGJORT WOOP WOOOP");
}
else if (gregoryHP == 0)
{
    Console.WriteLine($"{senkadenkaname} VANNNNN!!!!!! WOOP WOOPPPP");
}
else
{
    Console.WriteLine($"{gregoryname} VANNNNN!!!!! WOOOP WOOOOP");
}

Console.WriteLine("Tryck på valfri knapp för att avsluta...");
Console.ReadLine();