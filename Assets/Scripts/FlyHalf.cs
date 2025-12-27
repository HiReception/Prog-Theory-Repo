using UnityEngine;

// INHERITANCE
public class FlyHalf : Kicker
{
    public readonly string PlayerName = "Cameron Cronk";

    // POLYMORPHISM
    protected override void Kick(GameObject ball)
    {
        UpdateStatus("Drop kicking ball...");
        // TODO
    }
}
