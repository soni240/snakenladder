// See https://aka.ms/new-console-template for more information

static void Main(string[] args)
{
    
        int playerPos = 0, rollDice; int playerPos = 0, rollDice;
        //creates random number for rolling dice
        Random random = new Random(); Random random = new Random();
        rollDice = random.Next(1, 7); rollDice = random.Next(1, 7);
        Console.WriteLine("Rolled Dice number is:" + rollDice); Console.WriteLine("Rolled Dice number is:" + rollDice);
        // print user option
        Console.WriteLine("Player Option 1.No Play 2.Ladder 3.Snake");
        var list = new List<string> { "No Play", "Ladder", "Snake" };
        //check user option
        int pos = random.Next(list.Count);
        //condition based on user option
        if (list[pos] == "Ladder")
        {
            playerPos += rollDice;

        }
        else if (list[pos] == "Snake")
        {
            playerPos -= rollDice;

        }

        //print result of playerposition and dice rolled
        Console.WriteLine("Player option:" + list[pos]);
        Console.WriteLine("player updated position:" + playerPos);

    
}
    




