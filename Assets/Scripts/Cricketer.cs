using UnityEngine;

// INHERITANCE
public class Cricketer : Hitter
{
    public override string SenderName
    {
        get { return "Marnus Maxwell"; }
    }

    // POLYMORPHISM
    protected override void Hit(GameObject ball)
    {
        UpdateStatus("Slogging ball...");
        // TODO
    }
}
