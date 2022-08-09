using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PrintJSONTesting : MonoBehaviour
{
    public TextAsset textJSON;

    [SerializeField]
    public Text title;
    [SerializeField]
    public Text description;

    void Awake()
    {
         ChangeLanguage();
    }

    void Update()
    {
        ChangeLanguage();
    }

    void ChangeLanguage()
    {
        switch(LanguageController.CurrentLanguage)
        {
            case Language.HRV:
                title.text = JSONReader.GetJSON(textJSON).screen2title_HRV;    
                description.text = JSONReader.GetJSON(textJSON).screen2description_HRV;
                break;
            case Language.ENG:
                title.text = JSONReader.GetJSON(textJSON).screen2title_ENG;    
                description.text = JSONReader.GetJSON(textJSON).screen2description_ENG;
                break;
        }
    }

}

public static class JSONReader
    {
        public static JSONGetter GetJSON(TextAsset json)
        {
            JSONGetter getter = JsonUtility.FromJson<JSONGetter>(json.text);
            return getter;
        }
    }

[System.Serializable]
public class JSONGetter
{
    public string screen2description_HRV,screen2description_ENG,screen2title_HRV,screen2title_ENG;
}
