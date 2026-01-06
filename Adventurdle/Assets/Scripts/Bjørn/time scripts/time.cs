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

<<<<<<< HEAD
       timeText.text = $"{timer}";
=======
        var ballTime = timer;
        ballTime = Mathf.Round(ballTime);

        timeText.text = $"{ballTime}";
>>>>>>> 4916ab65f7fd92bd893ffe8386d492cead4ec05b
    }
}
