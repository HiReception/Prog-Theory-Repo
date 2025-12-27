using UnityEngine;

public abstract class Sender : ScriptableObject
{
    // ABSTRACTION
    public abstract void Send(GameObject ball);

    // ENCAPSULATION
    public virtual string SenderName
    {
        get { return ""; }
    }

    protected void UpdateStatus(string status)
    {
        // TODO
        Debug.Log(status);
    }
}
