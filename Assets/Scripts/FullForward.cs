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
        ball.transform.position = new Vector3(0, 0.75f, 0);
        ball.GetComponent<Rigidbody>().linearVelocity = Vector3.zero;
        ball.GetComponent<Rigidbody>().AddForce((Vector3.up + Vector3.forward) * 10, ForceMode.Impulse);
    }
}
