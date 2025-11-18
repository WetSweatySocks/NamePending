using UnityEngine;
using TMPro;
public class WordleEnterer : MonoBehaviour
{
    WordPicker WP;   
    public TMP_Text guessedWord;

    private void Start()
    {
        WP = GetComponent<WordPicker>();
    }

    public void enterWord()
    {
        if(guessedWord != null && Input.GetKeyDown(KeyCode.KeypadEnter))
        {
            checkWord();
        }
    }


    public void checkWord()
    {
        string typedWord = guessedWord.text;
        string usedWord = WP.SelectedWord;
        for (int i = 0; i < typedWord.Length; i++)
        {
            if (typedWord[i] == usedWord[i])
            {
                
            }
            else if(usedWord.Contains(typedWord[i]))
            {

            }
        }
    }


}
