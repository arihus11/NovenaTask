using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class LanguageController : MonoBehaviour
{
    [SerializeField]
    private Text[] _options;
    public static Language CurrentLanguage;

    void Awake() 
    {
        SelectLanguage(0);
    }


    public void SelectLanguage(int selectedTextIndex)
    {
        _options[selectedTextIndex].color = Color.grey;
        switch(CurrentLanguage)
        {
            case Language.HRV:
                if(selectedTextIndex == 0)
                {
                    break;
                }
                else{
                    CurrentLanguage = Language.ENG;   
                    break;
                }
            case Language.ENG:
                if(selectedTextIndex == 1)
                    {
                        break;
                    }
                else{
                    CurrentLanguage = Language.HRV;   
                    break;
                }
                break;
        }

        DeselectLanguage(selectedTextIndex);
    }

    void DeselectLanguage(int selectedTextIndex)
    {
        for(int i=0;i<_options.Length;i++)
        {
            if(i == selectedTextIndex)
            {
                continue;
            }
            else
            {
          //      Debug.Log("Language deselected: " + _options[i].text);
                _options[i].color = Color.black;
            }
        }
    }

}

public enum Language
{
    HRV,
    ENG,
}
