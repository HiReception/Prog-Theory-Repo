using TMPro;
using UnityEngine;

public class SenderButton : MonoBehaviour
{
    public Sender SenderInstance;
    private TextMeshProUGUI buttonText;
    private GameObject ball;
    private bool senderAttached = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        buttonText = GetComponentInChildren<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!senderAttached)
        {
            DetectSender();
        }
    }

    void DetectSender()
    {
        if (SenderInstance != null)
        {
            senderAttached = true;
            ball = GameObject.Find("Ball");

            buttonText.text = SenderInstance.SenderName + " (" + SenderInstance.GetType() + ")";
        }
        
    }

    public void SelectSender()
    {
        SenderInstance.Send(ball);
    }
}
