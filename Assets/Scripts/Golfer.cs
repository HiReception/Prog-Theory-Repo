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
        ball.transform.position = new Vector3(0, 0.25f, 0);
        ball.GetComponent<Rigidbody>().linearVelocity = Vector3.zero;
        ball.GetComponent<Rigidbody>().AddForce((Vector3.up + Vector3.forward) * 30, ForceMode.Impulse);
    }
}
