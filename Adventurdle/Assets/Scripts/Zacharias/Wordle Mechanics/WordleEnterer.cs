using UnityEngine;
using TMPro;
public class WordleEnterer : MonoBehaviour
{
    TMP_Text text;

    private void Start()
    {
        string hej = "abe";
        string hej2 = "jul";
        for (int i = 0; i < hej.Length; i++)
        {
            if (hej[i] == hej2[0])
            {
                if(i == 0)
                {
                    break;
                }
            }
        }
       
    }
}
