initiate();

void initiate()
{
    header();
    mainmenu();
}

void header()
{
    Console.WriteLine("*******");
    Console.WriteLine("*QWIXX*");
    Console.WriteLine("*******");
    Console.WriteLine();
}

void mainmenu()
{
    Console.WriteLine("1. New game");
    Console.WriteLine("2. High scores");
    Console.WriteLine("3. Quite");
}