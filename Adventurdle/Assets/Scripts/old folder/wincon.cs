using UnityEditorInternal.Profiling.Memory.Experimental;
using UnityEngine;

public class wincon : MonoBehaviour
{
    time time;
    doorcount DC;

    void Start()
    {
        time = FindFirstObjectByType<time>();
        DC = FindFirstObjectByType<doorcount>();
    }

     public void GuessedWordCorrect()
       {
        DC.doorCount += 1;

        time.timer += time.getTime;

        if (time.timer > time.maxTimer)
        {
            time.timer = time.maxTimer;
        }
    }
}
