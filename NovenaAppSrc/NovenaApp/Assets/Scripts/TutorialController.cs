using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialController : MonoBehaviour
{
    public static bool TutorialPanelOpened = true;
    [SerializeField]
    private GameObject _tutorialPanel;
    [SerializeField] GameObject[] _buttons;
    
    void Start()
    {
        TutorialPanelOpened = true;
    }

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            if(TutorialPanelOpened)
            {
                _tutorialPanel.gameObject.SetActive(false);
                TutorialPanelOpened = false;
                foreach(GameObject button in _buttons)
                {
                    button.gameObject.SetActive(true);
                }
            }
        }
    }

}
