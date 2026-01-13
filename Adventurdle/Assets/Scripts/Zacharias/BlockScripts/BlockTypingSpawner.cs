using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BlockTypingSpawner : MonoBehaviour
{
    [System.Serializable]
    public class LetterPrefab
    {
        public char letter;
        public GameObject prefab;
    }

    public TMP_InputField inputField;
    public LetterPrefab[] letterPrefabs;

    public Vector3 startPosition;
    public float spacing = 1.5f;

    // New: starting rotation for spawned letters
    public Vector3 startRotationEuler = Vector3.zero;

    private string previousText = "";
    private Dictionary<char, GameObject> prefabLookup = new Dictionary<char, GameObject>();
    private List<GameObject> spawnedObjects = new List<GameObject>();

    void Awake()
    {
        foreach (var lp in letterPrefabs)
        {
            prefabLookup[char.ToLower(lp.letter)] = lp.prefab;
        }

        inputField.onValueChanged.AddListener(OnTextChanged);
    }

    void OnTextChanged(string newText)
    {
        newText = newText.ToLower();

        while (spawnedObjects.Count > newText.Length)
        {
            Destroy(spawnedObjects[^1]);
            spawnedObjects.RemoveAt(spawnedObjects.Count - 1);
        }

        // Convert Euler angles to Quaternion once
        Quaternion rotation = Quaternion.Euler(startRotationEuler);

        // Add new objects
        for (int i = spawnedObjects.Count; i < newText.Length; i++)
        {
            char c = newText[i];

            if (!prefabLookup.ContainsKey(c))
                continue;

            Vector3 pos = startPosition + Vector3.right * spacing * i;
            GameObject obj = Instantiate(prefabLookup[c], pos, rotation);
            spawnedObjects.Add(obj);
            obj.GetComponent<Renderer>().material.color = Color.yellow;
        }

        previousText = newText;
    }
}
