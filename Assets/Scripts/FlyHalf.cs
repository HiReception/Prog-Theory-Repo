using UnityEngine;

// INHERITANCE
public class FlyHalf : Kicker
{
    public override string SenderName
    {
        get { return "Cameron Cronk"; }
    }

    // POLYMORPHISM
    protected override void Kick(GameObject ball)
    {
        UpdateStatus("Drop kicking ball...");
        // TODO
    }
}
