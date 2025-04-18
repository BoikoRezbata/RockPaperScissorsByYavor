﻿const string Rock = "Rock";
const string Paper = "Paper";
const string Scissors = "Scissors";

Console.Write("Choose [r]ock, [p]aper, [s]cissors: ");
string playerMove = Console.ReadLine();
if (playerMove == "r" || playerMove == "rock")
{
    playerMove = Rock;
}
else if (playerMove == "p" || playerMove == "paper")
{
    playerMove = Paper;
}
else if (playerMove == "s" || playerMove == "scissors")
{
    playerMove = Scissors;
}
else
{
    Console.WriteLine("Invalid Input. Try Again. . .");
    return;
}
Random random = new Random();
int ComputerRandomNumber = random.Next(1, 4);
string computerMove = "";
switch (ComputerRandomNumber)
{
    case 1:
        computerMove = Rock;
        break;
    case 2:
        computerMove = Paper;
        break;
    case 3:
        computerMove = Scissors;
        break;
}
Console.WriteLine($"The Computer chose {computerMove}.");
if ((playerMove == Rock && computerMove == Scissors) || 
    (playerMove == Paper && computerMove == Rock) || 
    (playerMove == Scissors && computerMove == Paper))
{
    Console.WriteLine("You Win.");
}
else if ((playerMove == Scissors && computerMove == Rock) ||
        (playerMove == Rock && computerMove == Paper) ||
        (playerMove == Paper && computerMove == Scissors))
{
    Console.WriteLine("You Lose.");
}
else
{
    Console.WriteLine("This game was a draw.");
}
