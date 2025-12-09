using UnityEngine;
using TMPro;
using Unity.VisualScripting;

public class time : MonoBehaviour
{
    public float timer = 300;
    public float maxTimer = 300;
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

        if (Input.GetKeyDown(KeyCode.Space))
        {
            GuessedWordCorrect();
        }

        timeText.text = $"{timer}";
    }

    public void GuessedWordCorrect()
    {
        DC.doorCount += 1;

        timer += getTime;

        if (timer > maxTimer)
        {
            timer = maxTimer;
        }
    }
}
