using UnityEngine;

// INHERITANCE
public abstract class Kicker : Sender
{
    // POLYMORPHISM
    public override void Send(GameObject ball)
    {
        Kick(ball);
    }

    protected abstract void Kick(GameObject ball);
}
