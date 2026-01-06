using UnityEditorInternal.Profiling.Memory.Experimental;
using UnityEngine;

public class wincon : MonoBehaviour
{
    WordPicker WP;
    time time;
    doorcount DC;

    void Start()
    {
        WP = FindFirstObjectByType<WordPicker>();
        time = FindFirstObjectByType<time>();
        DC = FindFirstObjectByType<doorcount>();
    }

     public void GuessedWordCorrect()
    {
        Debug.Log("Wincon has been met");

        DC.doorCount += 1;

        time.timer += time.getTime;

        WP.pickNewWord();

        if (time.timer > time.maxTimer)
        {
            time.timer = time.maxTimer;
        }
    }
}
