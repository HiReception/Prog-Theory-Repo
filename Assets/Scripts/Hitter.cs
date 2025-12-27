using UnityEngine;

// INHERITANCE
public abstract class Hitter : Sender
{
    // POLYMORPHISM
    public override void Send(GameObject ball)
    {
        Hit(ball);
    }

    protected abstract void Hit(GameObject ball);
}
