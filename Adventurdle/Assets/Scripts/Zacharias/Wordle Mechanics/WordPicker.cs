using UnityEngine;
using System.Collections.Generic;
public class WordPicker : MonoBehaviour
{

    public List<string> wordList = new List<string>();

    public string SelectedWord;

   /* private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            pickNewWord();
        }
    }*/

    public void pickNewWord()
    {
       if(wordList == null || wordList.Count == 0)
        {
            return;
        }

        int index = Random.Range(0, wordList.Count);
        SelectedWord = wordList[index];
    }
}
