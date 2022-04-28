// See https://aka.ms/new-console-template for more information

playerPos -= rollDice;
                    }
             }
             else if (playerPos + rollDice == 100)
             {
    playerPos += rollDice;

	@@ -55,7 + 55,7 @@ static void Main(string[] args)
             Console.WriteLine("Player current position : " + playerPos);
    count++;
    Console.WriteLine("Final position is :" + playerPos);
    Console.WriteLine("number of times:" + count);
             }

             