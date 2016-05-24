class Program
{
    static void Main(string[] args)
    {

        // Second, our coe here is now incorrect; the contstructor
        // requires a name.

        // Notice that in the class before it had a constructor, we got
        // a parameterless "default" constructor for free.  The free one
        // goes away as soon as you define a custom constructor.

        //var player = new Player();
        //player.Name = "Eric";

        var player = new Player("Eric");

        // Fourth, now we have the same problem here:

        //var game = new Hangman();
        //game.Player = player;

        var game = new Hangman(player);

        // What if we wanted sensible defaults, as a convenience for
        // the users of these classes?

        // After we have done so we can simply say:

        game = new Hangman();

        game.Guess('a');
    }
}