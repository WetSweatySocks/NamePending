using UnityEngine;
using TMPro;
public class WordleEnterer : MonoBehaviour
{
    public TMP_Text guessedWord;

    private void Start()
    {
        string typedWord = guessedWord.text;
        string selectedWord = "jul";
        for (int i = 0; i < typedWord.Length; i++)
        {
            if (typedWord[i] == selectedWord[i])
            {

                if(i == 0)
                {
                    break;
                }
            }
        }
    }
}
