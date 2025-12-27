using UnityEngine;

public abstract class Sender : MonoBehaviour
{
    // ABSTRACTION
    public abstract void Send(GameObject ball);

    // ENCAPSULATION
    public string SenderName { get; }

    protected void UpdateStatus(string status)
    {
        // TODO
        Debug.Log(status);
    }
}
