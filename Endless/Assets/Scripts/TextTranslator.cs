using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextTranslator : MonoBehaviour
{
    [Tooltip("0 = English, 1 = Turkish")]
    public string[] translations;

    public void UpdateTexts(int index)
    {
        GetComponent<TMPro.TMP_Text>().text = translations[index];
    }
}
