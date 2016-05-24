using System;

class Player
{
    // First, let's add a constructor

    // I like to put ctors at the top of classes, but they can go anywhere.

    public Player(string name)
    {
        if (name == null)
            throw new ArgumentNullException(nameof(name));
        this.Name = name;
        // "this." is optional; put it in if you find it more clear
    }


    // Fifth, let's create a paramterless constructor that calls our other
    // constructor.

    public Player() 
        : this("Anonymous")
    { }

    public string Name { get; set; }
}