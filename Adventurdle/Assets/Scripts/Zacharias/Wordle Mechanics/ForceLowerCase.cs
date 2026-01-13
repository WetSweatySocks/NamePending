using TMPro;
using UnityEngine;

[RequireComponent(typeof(TMP_InputField))]
public class ForceLowerCase : MonoBehaviour
{
    TMP_InputField input;
    bool internalChange;

    void Awake()
    {
        input = GetComponent<TMP_InputField>();
        input.onValueChanged.AddListener(OnValueChanged);
    }

    void OnValueChanged(string value)
    {
        if (internalChange) return;

        string lower = value.ToLower();
        if (value == lower) return; // critical: do nothing if already lowercase

        internalChange = true;

        int caret = input.caretPosition;
        input.text = lower;
        input.caretPosition = caret;

        internalChange = false;
    }
}
