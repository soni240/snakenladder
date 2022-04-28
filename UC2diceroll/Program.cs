// See https://aka.ms/new-console-template for more information

{
    static void Main(string[] args)
    {
        int playerPos = 0, rollDice;
        Random random = new Random();
        rollDice = random.Next(1, 7);
        Console.WriteLine("Rolled Dice number is:" + rollDice);
    }
}
}