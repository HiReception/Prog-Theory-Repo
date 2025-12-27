using UnityEngine;

// INHERITANCE
public class Pitcher : Thrower
{
    public readonly string PlayerName = "Randy Young";

    // POLYMORPHISM
    protected override void Throw(GameObject ball)
    {
        UpdateStatus("Pitching ball...");
        // TODO
    }
}
