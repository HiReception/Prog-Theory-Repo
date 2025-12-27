using UnityEngine;

// INHERITANCE
public class Cricketer : Hitter
{
    public readonly string PlayerName = "Marnus Maxwell";

    // POLYMORPHISM
    protected override void Hit(GameObject ball)
    {
        UpdateStatus("Slogging ball...");
        // TODO
    }
}
