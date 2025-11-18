using UnityEngine;
using TMPro;
using Unity.VisualScripting;

public class time : MonoBehaviour
{
    public float timer = 300;
    public float maxTimer = 300;
    public int getTime = 30;
    public TMP_Text timeText;

    private void Update()
    {
        timer -= Time.deltaTime;

        if (timer <= 0)
        {
            Die();
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            GuessedWordCorrect();
        }

        timeText.text = $"{timer}";
    }

    public void Die()
    {
        print("YOU DEID");
    }

    public void GuessedWordCorrect()
    {
        timer += getTime;

        if (timer > maxTimer)
        {
            timer = maxTimer;
        }
    }
}
