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






    // This is a read-write property of type string
    // called Name.

    // We'll look at properties in more detail in a 
    // later video.

    // Why public? We'll look at that later as well.

    public string Name { get; set; }
}