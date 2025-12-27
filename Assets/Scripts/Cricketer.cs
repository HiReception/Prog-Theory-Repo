using UnityEngine;

// INHERITANCE
public class Cricketer : Hitter
{
    public override string SenderName
    {
        get { return "Marnus Maxwell"; }
    }

    // POLYMORPHISM
    protected override void Hit(GameObject ball)
    {
        UpdateStatus("Slogging ball...");
        ball.transform.position = new Vector3(0, 0.35f, 0);
        ball.GetComponent<Rigidbody>().linearVelocity = Vector3.zero;
        ball.GetComponent<Rigidbody>().AddForce((Vector3.up + (Vector3.forward * 3)) * 5, ForceMode.Impulse);
    }
}
