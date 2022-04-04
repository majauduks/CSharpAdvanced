


using SEDC.Oop.CsharpAdv.Class01.Exercise03;

    bool okay = true;
    Player game = new Player();
while (okay)
{
    Console.WriteLine("Do you want to play a game? Press 1 for play, 2 for stats and 3 for exit!");
    string answer = Console.ReadLine();
    bool isOKay = int.TryParse(answer, out int answerInt);
    isOKay = isOKay && answerInt > 0 && answerInt <= 3;
    if(!isOKay)
    {
        Console.WriteLine("Enter a valid choice!");
    }
    else if (isOKay)
    {
        //bool statement = false;
        //while (statement)
        //{

        //    if (answerInt != 1 && answerInt != 2 && answerInt != 3)
        //    {
        //        Console.WriteLine("Enter a valid choice!");
        //        continue;
        //    }
        //    else
        //    {
        //        statement = true;

        //    }
        //}


        if (answerInt == 1)
        {
            Console.WriteLine("Enter 1 for rock, 2 for paper and 3 for scisors");
            string choice = Console.ReadLine();
            bool isOKayChoice = int.TryParse(choice, out int choiceInt);
            isOKayChoice = isOKayChoice && choiceInt > 0 && choiceInt < 4;
            //while (isOKayChoice)
            //{
                if (isOKayChoice)
                {
                //if (choiceInt != 1 && choiceInt != 2 && choiceInt != 3)
                //{
                //    Console.WriteLine("Enter a valid choice!");
                //    continue;
                //}
                RPC userChoiceRPC = (RPC)choiceInt;
                  //  Enum.TryParse("choice", out RPC choiceToRPC);
                    game.Play(userChoiceRPC);
                    
                }

            //}
        }
        else if (answerInt == 2)
        {
            Console.WriteLine($"The computer has won {game.CounterComputer} times and you have won {game.CounterPlayer} times!");
        }

        else if (answerInt == 3)
        {
            Console.WriteLine("You have exited the game");
            okay = false;
        }
    }
}



    // RPC answerToRPC = new RPC();

   
















