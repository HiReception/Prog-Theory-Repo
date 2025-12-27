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
        ball.transform.position = new Vector3(0, 1.75f, 0);
        ball.GetComponent<Rigidbody>().linearVelocity = Vector3.zero;
        ball.GetComponent<Rigidbody>().AddForce((Vector3.up + (Vector3.forward * 2)) * 15, ForceMode.Impulse);
    }
}
