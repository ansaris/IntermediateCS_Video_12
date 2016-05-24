using System;
using System.Collections.Generic;


class Hangman
{
    // Third, we can do the same thing to our game class...

    public Hangman(Player player)
    {
        if (player == null)
            throw new ArgumentNullException(nameof(player));
        Player = player;
    }

    public Hangman() 
        : this(new Player())
    {

    }

    public Player Player { get; set; }

    public List<string> WordList { get; set; }

    public string Word { get; set; }

    public Outcome Outcome { get; set; }

    public void Guess(char letter)
    {
        // Game logic for a player's guess goes here.

        // Let's debug this program and see what we see.

        // An instance method differs from a static method
        // in that it has a "this"

        // In a class method, "this" is not a variable;  you cannot
        // change it. It is a value. The value is a reference to the 
        // receiver of the call.

        // Notice that the unset properties of reference type are
        // automatically set to null; properties do not have to
        // be initially assigned, unlike local variables.

        // Why is Outcome initially InProgress?
    }

}

