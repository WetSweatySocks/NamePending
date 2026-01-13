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
        if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Word Entered");
            enterWord();
        }
    }

    private void Start()
    {
        WC = FindFirstObjectByType<wincon>();
        WP = GetComponent<WordPicker>();
    }

    public void enterWord()
    {
        if(EnteredWord != null)
        {
            Debug.Log("Word Sent to Check");
            checkWord();
        }
    }

   public void checkWord()
{
    string typedWord = EnteredWord.text.ToLowerInvariant();
    string usedWord = WP.SelectedWord.ToLowerInvariant();

    for (int i = 0; i < typedWord.Length; i++)
    {
        // Exact letter + position match
        if (typedWord[i] == usedWord[i])
        {
            Debug.Log("Word Is Correct!");
            WC.GuessedWordCorrect();
            presentLetters.Clear();
            EnteredWord.text = "";
            break;
        }
        // Letter exists somewhere in the word
        else if (usedWord.Contains(typedWord[i]))
        {
            if (!presentLetters.Contains(typedWord[i]))
            {
                presentLetters.Add(typedWord[i]);
            }
        }
    }
}
}
