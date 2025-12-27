using UnityEngine;

// INHERITANCE
public class Golfer : Hitter
{
    public override string SenderName
    {
        get { return "Adam Appleby"; }
    }

    // POLYMORPHISM
    protected override void Hit(GameObject ball)
    {
        UpdateStatus("Driving ball...");
        // TODO
    }
}
