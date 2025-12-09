using UnityEngine;
using TMPro;
using System.Collections.Generic;
public class WordleEnterer : MonoBehaviour
{
    wincon WC;
    WordPicker WP;

    public TMP_InputField EnteredWord;

    public List<char> presentLetters = new List<char>();

    private void Update()
    {
        string typedWord = EnteredWord.text;
    }

    private void Start()
    {
        WC = FindFirstObjectByType<wincon>();
        WP = GetComponent<WordPicker>();
    }

    public void enterWord()
    {
        if(EnteredWord != null && Input.GetKeyDown(KeyCode.KeypadEnter))
        {
            checkWord();
        }
    }

    public void checkWord()
    {
        string typedWord = EnteredWord.text;
        string usedWord = WP.SelectedWord;
        for (int i = 0; i < typedWord.Length; i++)
        {
            // Hvis ordet er 100% rigtigt

            if (typedWord[i] == usedWord[i])
            {
                
                presentLetters.Clear();
            }

            // Hvis ordet indenholder bogstavet, tilføj det til en liste
            else if(usedWord.Contains(typedWord[i].ToString()))
            {
                if (!presentLetters.Contains(typedWord[i]))
                {
                    presentLetters.Add(typedWord[i]);
                }
            }
        }
    }


}
