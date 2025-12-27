using UnityEngine;

// INHERITANCE
public class FullForward : Kicker
{
    public readonly string PlayerName = "Gordon Lockett";

    // POLYMORPHISM
    protected override void Kick(GameObject ball)
    {
        UpdateStatus("Drop punting ball...");
        // TODO

    }
}
