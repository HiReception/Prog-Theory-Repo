using UnityEngine;

// INHERITANCE
public class Quarterback : Thrower
{
    public override string SenderName
    {
        get { return "Dan Montana"; }
    }

    // POLYMORPHISM
    protected override void Throw(GameObject ball)
    {
        UpdateStatus("Heaving ball...");
        // TODO
    }
}
