using UnityEngine;

// INHERITANCE
public class Quarterback : Thrower
{
    public readonly string PlayerName = "Dan Montana";

    // POLYMORPHISM
    protected override void Throw(GameObject ball)
    {
        UpdateStatus("Heaving ball...");
        // TODO
    }
}
