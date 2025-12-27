using UnityEngine;

// INHERITANCE
public class Pitcher : Thrower
{
    public override string SenderName
    {
        get { return "Randy Young"; }
    }

    // POLYMORPHISM
    protected override void Throw(GameObject ball)
    {
        UpdateStatus("Pitching ball...");
        ball.transform.position = new Vector3(0, 1.75f, 0);
        ball.GetComponent<Rigidbody>().linearVelocity = Vector3.zero;
        ball.GetComponent<Rigidbody>().AddForce((Vector3.up + (Vector3.forward * 4)) * 5, ForceMode.Impulse);
    }
}
