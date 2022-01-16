// variables
string userMenuSelection = null;
int numberOfPlayers = 0;

Initiate();

void Initiate()
{
    // Draw program's header
    Header();

    // Draw program's menu
    MainMenu();

    // Handle user's menu selection
    while (userMenuSelection != "3")
    {
        switch (userMenuSelection)
        {
            case "1": // Start game
                StartGame();
                userMenuSelection = null;
                //header();
                //mainmenu();
                break;

            case "2": // Show highscores
                //ShowHighScores();
                //userMenuSelection = null;
                //header();
                //mainmenu();
                break;

            case "3": // Exit program
                Header();
                Console.WriteLine("See you next time! Exiting...");
                Console.WriteLine();
                Environment.Exit(0);
                break;
        }
    }
}

void Header()
{
    // Clear the console
    Console.Clear();

    // Draw program header
    Console.WriteLine("*******");
    Console.WriteLine("*QWIXX*");
    Console.WriteLine("*******");
    Console.WriteLine();
}

void MainMenu()
{
    while ((userMenuSelection != "1") & (userMenuSelection != "2") & (userMenuSelection != "3"))
    {
        Header();
        Console.WriteLine("1. New game");
        Console.WriteLine("2. High scores");
        Console.WriteLine("3. Exit");
        Console.Write("\r\nSelect an option: ");
        userMenuSelection = Console.ReadLine().ToUpper();
    }
}

void StartGame()
{
    // Check how many players will play
    while (numberOfPlayers < 2 || numberOfPlayers > 5)
    {
        Console.WriteLine("How many players will play?");
        numberOfPlayers = Convert.ToInt32(Console.ReadLine());
    }

    // Register players
    RegisterPlayers(numberOfPlayers);
    
}

void RegisterPlayers(int numberOfPlayers)
{
    for (int i=0; i<numberOfPlayers; i++)
    {

    }
}