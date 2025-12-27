using UnityEngine;

// INHERITANCE
public class ShotPutter : Thrower
{
    public override string SenderName
    {
        get { return "Scott Birkinhead"; }
    }

    // POLYMORPHISM
    protected override void Throw(GameObject ball)
    {
        UpdateStatus("Putting ball...");
        // TODO
    }
}
