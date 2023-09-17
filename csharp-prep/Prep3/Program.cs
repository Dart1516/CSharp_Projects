using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("What is the magic number? ");
        //string answer1 = Console.ReadLine();
        //int secret_number = int.Parse(answer1);
        
        Console.WriteLine("Wellcome to this game where do you have to guess a number between 1 - 100");
        Console.WriteLine("we wish you good luck");
        Console.WriteLine("");

        string  game_on ;
        do {
        
        Random randomGenerator = new Random();
        int secret_number = randomGenerator.Next(1, 100);
        int my_guest = 0;

        int how_many_tries = 0; 
        while (my_guest != secret_number) {
        Console.Write("What is your guess? ");
        string answer2 = Console.ReadLine();
        my_guest = int.Parse(answer2);

            if (my_guest > secret_number )
            {
                Console.WriteLine("Higher");
            }
            else if (my_guest < secret_number){
                Console.WriteLine("lower");
            }
            how_many_tries ++;
        }
        Console.WriteLine("You guessed it!");
        Console.WriteLine($"and you only try it {how_many_tries} times");
        Console.Write("Do you want to play again? ");
        game_on = Console.ReadLine();
}while (game_on == "yes");{
}  

}
}
