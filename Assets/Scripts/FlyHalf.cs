using UnityEngine;

// INHERITANCE
public class FlyHalf : Kicker
{
    public override string SenderName
    {
        get { return "Cameron Cronk"; }
    }

    // POLYMORPHISM
    protected override void Kick(GameObject ball)
    {
        UpdateStatus("Drop kicking ball...");
        ball.transform.position = new Vector3(0, 0.35f, 0);
        ball.GetComponent<Rigidbody>().linearVelocity = Vector3.zero;
        ball.GetComponent<Rigidbody>().AddForce(((Vector3.up * 2) + Vector3.forward) * 10, ForceMode.Impulse);
    }
}
