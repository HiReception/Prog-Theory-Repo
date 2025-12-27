using UnityEngine;

public class MainManager : MonoBehaviour
{
    public GameObject buttonPrefab;
    private GameObject[] buttons = new GameObject[8];
    private Sender[] senders;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        senders = new Sender[]
        {
            ScriptableObject.CreateInstance<FullForward>(),
            ScriptableObject.CreateInstance<Goalkeeper>(),
            ScriptableObject.CreateInstance<FlyHalf>(),
            ScriptableObject.CreateInstance<Quarterback>(),
            ScriptableObject.CreateInstance<ShotPutter>(),
            ScriptableObject.CreateInstance<Pitcher>(),
            ScriptableObject.CreateInstance<Golfer>(),
            ScriptableObject.CreateInstance<Cricketer>(),

        };

        for (int i = 0; i < senders.Length; i++)
        {
            GameObject button = Instantiate(buttonPrefab, GameObject.Find("SenderButtonCollection").transform);
            button.transform.Translate(0, -40*i, 0);
            button.GetComponent<SenderButton>().SenderInstance = senders[i];
            buttons[i] = button;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
