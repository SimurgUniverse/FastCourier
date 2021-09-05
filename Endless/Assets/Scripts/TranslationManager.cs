using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TranslationManager : MonoBehaviour
{
    public Dropdown dropdown;
    int langIndex;
    private void Start()
    {

        PopulateList();

        dropdown.onValueChanged.AddListener(delegate {
                OnValueChanged();
        });
        
    }

    private void Update()
    {
        
        dropdown.value = PlayerPrefs.GetInt("lang");
    }
    private void PopulateList()
    {
        List<string> languages = new List<string>()
        {
            "English",
            "Türkçe"
        };

        dropdown.AddOptions(languages);
    }

    private void OnValueChanged()
    {
        SetLanguageIndex(dropdown.value);

        SetAllTexts();
    }

    private void SetAllTexts()
    {
        TextTranslator[] texts = FindObjectsOfType(typeof(TextTranslator)) as TextTranslator[];

    

        for(int i = 0; i < texts.Length; i++)
        {
            texts[i].UpdateTexts(PlayerPrefs.GetInt("lang"));
        }
    }

  
    private void SetLanguageIndex(int index)
    {
        PlayerPrefs.SetInt("lang", index);
    }
}
