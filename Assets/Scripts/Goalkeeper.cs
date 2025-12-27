using UnityEngine;

// INHERITANCE
public class Goalkeeper : Kicker
{
    public override string SenderName
    {
        get { return "Eugene Theoklitos"; }
    }

    // POLYMORPHISM
    protected override void Kick(GameObject ball)
    {
        UpdateStatus("Kicking ball off ground...");
        // TODO
    }
}
