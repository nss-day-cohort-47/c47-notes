using System;
using System.Collections.Generic;
using System.Threading;

Main();

void Main()
{
    int winningScore = 3;

    int humanScore = 0;
    int computerScore = 0;

    while (true)
    {
        Console.Clear();
        DisplayScoreBoard(humanScore, computerScore);

        int humanMove = GetHumanMove();
        int computerMove = GetComputerMove();

        DisplayMoves(humanMove, computerMove);

        if (DidPlayerOneWin(humanMove, computerMove))
        {
            humanScore++;
        }
        else if (DidPlayerOneWin(computerMove, humanMove))
        {
            computerScore++;
        }

        if (humanScore == winningScore || computerScore == winningScore)
        {
            DisplayFinalScore(humanScore, computerScore);
            return;
        }
    }
}

void DisplayScoreBoard(int humanScore, int computerScore)
{
    Console.WriteLine(
$@"
----------------------------------------
|       Human: {humanScore}   |   Computer: {computerScore}     |
----------------------------------------"
    );
}

int GetHumanMove()
{
    Console.WriteLine("What would you like to throw?");
    Console.WriteLine(" 1) Rock");
    Console.WriteLine(" 2) Paper");
    Console.WriteLine(" 3) Scissors");

    while (true)
    {
        Console.Write("> ");
        string choice = Console.ReadLine();

        if (int.TryParse(choice, out int intChoice) && intChoice > 0 && intChoice < 4)
        {
            return intChoice - 1;
        }
    }
}

int GetComputerMove()
{
    return new Random().Next(3);
}

void DisplayMoves(int humanMove, int computerMove)
{
    DisplayMove(humanMove);
    Console.WriteLine();
    Console.WriteLine(" --VS--");
    DisplayMove(computerMove);

    Thread.Sleep(750);
}

void DisplayMove(int move)
{
    List<string> moves = new List<string>() {
@"
    _______
---'   ____)
      (_____)
      (_____)
      (____)
---.__(___)
",
@"
     _______
---'    ____)____
           ______)
          _______)
         _______)
---.__________)
",
@"
    _______
---'   ____)____
          ______)
       __________)
      (____)
---.__(___)
"};

    Console.WriteLine(moves[move]);
}

bool DidPlayerOneWin(int playerOneMove, int playerTwoMove)
{
    return playerOneMove == ((playerTwoMove + 1) % 3);
}

void DisplayFinalScore(int humanScore, int computerScore)
{
    Console.Clear();
    DisplayScoreBoard(humanScore, computerScore);

    string resultMssage = humanScore == 3 ? "YOU WIN!" : "YOU LOSE!";
    Console.WriteLine(resultMssage);
    Console.WriteLine();
    Console.WriteLine();
}