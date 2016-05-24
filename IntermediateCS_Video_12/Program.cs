class Program
{
    static void Main(string[] args)
    {

        // Second, our coe here is now incorrect; the contstructor
        // requires a name.

        // Notice that in the class before it had a constructor, we got
        // a parameterless "default" constructor for free.  The free one
        // goes away as soon as you define a custom constructor.

        var player = new Player();
        player.Name = "Eric";

        //var player = new Player("Eric");

        // Fourth, now we have the same problem here:

        var game = new Hangman();

        game.Player = player;

        game.Guess('a');
    }
}