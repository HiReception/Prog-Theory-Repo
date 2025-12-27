using UnityEngine;

// INHERITANCE
public class FullForward : Kicker
{
    public override string SenderName
    {
        get { return "Gordon Lockett"; }
    }

    // POLYMORPHISM
    protected override void Kick(GameObject ball)
    {
        UpdateStatus("Drop punting ball...");
        // TODO

    }
}
