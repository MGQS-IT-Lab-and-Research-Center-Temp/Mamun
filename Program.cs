// Build Dice Game
Console.WriteLine("===Simple Dice Game === \nType 'start' or 's' to roll the die:");

string startGame = Console.ReadLine()!;

if (!(startGame.Equals("Start", StringComparison.OrdinalIgnoreCase) || startGame.Equals("S", StringComparison.OrdinalIgnoreCase)));

    Console.WriteLine("Enter 's' to start the game properly");
    Console.WriteLine("You started the game!!!");


    Random random = new();
    int diceOne = random.Next (1, 7);
    int diceTwo = random.Next (1, 7);
    int diceThree = random.Next (1, 7);
    int originalScore = diceOne + diceTwo + diceThree;
    const int DOUBLE_POINT = 2;
    const int TRIPLE_POINT = 6;
    int totalPoint = originalScore;

    if (diceOne == diceTwo && diceTwo == diceThree)
    {
        totalPoint += TRIPLE_POINT;

        Console.WriteLine($"Dice One: {diceOne}\n Dice Two; {diceTwo}\n Dice Three: {diceThree}\nYou roll triple! you have a total of {totalPoint} points");
    }

    else if (diceOne == diceTwo || diceTwo == diceThree || diceOne == diceThree)
    {
        totalPoint += DOUBLE_POINT;

        Console.WriteLine( totalPoint);
        // Console.WriteLine("");
    }

if (totalPoint >=10 && totalPoint <=13)
{
    System.Console.WriteLine("congratulations you won a baloon");
}

 if (totalPoint >=14 && totalPoint <=16)
{
    System.Console.WriteLine("you won exercise book");
}

if (totalPoint ==17)
{
    System.Console.WriteLine("congratulations you won 500MH power bank");
}

 if (totalPoint >=18 && totalPoint <=20)
{
    System.Console.WriteLine("you won a ticket to silverbird");
}
 if (totalPoint ==21)
{
    System.Console.WriteLine("congratulations you won SAMSUNGA 24");
}
else if (totalPoint >=22 && totalPoint <=24)
{
    System.Console.WriteLine("congratulations you All the Items");

}