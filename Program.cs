using System;
using Game.Models;
class ProjectName
{

  public static void Welcome()
{
  Console.WriteLine(@"(  _ \ /  \  / __)(  / )  (  _ \ / _\ (  _ \(  __)(  _ \  / ___) / __)(  )/ ___)/ ___) /  \(  _ \/ ___)");
  Console.WriteLine(@" )   /(  O )( (__  )  (    ) __//    \ ) __/ ) _)  )   /  \___ \( (__  )( \___ \\___ \(  O ))   /\___ \");
  Console.WriteLine(@"(__\_) \__/  \___)(__\_)  (__)  \_/\_/(__)  (____)(__\_)  (____/ \___)(__)(____/(____/ \__/(__\_)(____/");
}
  static void Main()
  {
    Welcome();
    Console.WriteLine("Would you like to start a game? (Y/N)");
    string answer = Console.ReadLine();
    if (answer == "Y" || answer == "y")
    {
      Console.WriteLine("Let's play!");
      //method for game play gets called here
    }
     else if (answer == "N" || answer == "n")
     {
        Console.WriteLine("I didn't want to play anyway.");

    }else
      {
        Console.WriteLine("Please enter Y or N");
      }
      UserGamePlay();
      ComputerGamePlay();
    }

  static void UserGamePlay()
  {
    Console.WriteLine("Make your move! (rock/paper/scissors)");
    string answer = Console.ReadLine();
    Console.WriteLine("You chose " + answer + ".");
    Console.WriteLine("------------------------------");
  }
  static void ComputerGamePlay()
  {
    Random rnd = new Random();
    string[] computerAnswers = { "Rock", "Paper", "Scissors" };

    int moveIndex = rnd.Next(computerAnswers.Length);

    Console.WriteLine("My move:");
    Console.WriteLine(computerAnswers[moveIndex]);
  }

  static void CheckAnswer()
  {
    if (answer == computerAnswers[moveIndex]) 
    {
      Console.WriteLine("You tied!");
    }
  }
}


