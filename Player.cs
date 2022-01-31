class Player
{
    private string name;
    private Game game;
    bool win = false;
    bool lose = false;

    public Player(string name, Game craps)
    {
        this.name = name;
        this.game = craps;
    }

    public void NextStep()
    {

        Console.WriteLine("Press Enter to next step");
        Console.ReadLine(); 
        game.NextStep();
    }

    public string Name { get { return name; } }

    public bool IsLose 
    { 
        get { return lose; } 
        set { lose = value; }
    }

    public bool IsWin 
    {
        get { return win; }
        set { win = value; }
    }
}