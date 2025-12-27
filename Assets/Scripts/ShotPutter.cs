using UnityEngine;

// INHERITANCE
public class ShotPutter : Thrower
{
    public readonly string PlayerName = "Scott Birkinhead";

    // POLYMORPHISM
    protected override void Throw(GameObject ball)
    {
        UpdateStatus("Putting ball...");
        // TODO
    }
}
