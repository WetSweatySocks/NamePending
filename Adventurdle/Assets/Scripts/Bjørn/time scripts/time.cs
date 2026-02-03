using UnityEngine;
using TMPro;
using Unity.VisualScripting;

public class time : MonoBehaviour
{
    public float timer = 300;
    public float maxTimer = 360;
    public int getTime = 30;
    public TMP_Text timeText;

    doorcount DC;

    private void Start()
    {
        DC = FindFirstObjectByType<doorcount>();
    }

    private void Update()
    {
        if (timer > 0)
        {
            timer -= Time.deltaTime;
        }
        else
        {
            timer = 0;
        }

        if (timer > maxTimer)
        {
            timer = maxTimer;
        }

       timeText.text = $"{timer}";

        timeText.text = $"{timer}";


        var ballTime = timer;
        ballTime = Mathf.Round(ballTime);

        timeText.text = $"{ballTime}";

    }
}
