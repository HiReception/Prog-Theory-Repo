using UnityEngine;

// INHERITANCE
public class Goalkeeper : Kicker
{
    public readonly string PlayerName = "Eugene Theoklitos";

    // POLYMORPHISM
    protected override void Kick(GameObject ball)
    {
        UpdateStatus("Kicking ball off ground...");
        // TODO
    }
}
