using UnityEngine;

// INHERITANCE
public class Pitcher : Thrower
{
    public override string SenderName
    {
        get { return "Randy Young"; }
    }

    // POLYMORPHISM
    protected override void Throw(GameObject ball)
    {
        UpdateStatus("Pitching ball...");
        // TODO
    }
}
