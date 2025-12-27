using UnityEngine;

// INHERITANCE
public class Goalkeeper : Kicker
{
    public override string SenderName
    {
        get { return "Eugene Theoklitos"; }
    }

    // POLYMORPHISM
    protected override void Kick(GameObject ball)
    {
        UpdateStatus("Kicking ball off ground...");
        ball.transform.position = new Vector3(0, 0.25f, 0);
        ball.GetComponent<Rigidbody>().linearVelocity = Vector3.zero;
        ball.GetComponent<Rigidbody>().AddForce((Vector3.up + Vector3.forward) * 10, ForceMode.Impulse);
    }
}
