using UnityEngine;

// INHERITANCE
public abstract class Thrower : Sender
{
    // POLYMORPHISM
    public override void Send(GameObject ball)
    {
        Throw(ball);
    }

    protected abstract void Throw(GameObject ball);
}
