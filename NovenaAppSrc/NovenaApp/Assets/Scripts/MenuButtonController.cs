using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuButtonController : MonoBehaviour
{
    [SerializeField]
    private GameObject[] _rectangles;
    public static bool MenuOpened;

    void Start() 
    {
        MenuOpened = false;
    }

    public void OpenMenu()
    {
        _rectangles[0].SetActive(false);
        _rectangles[1].SetActive(true);
        MenuOpened = true;
    }

    public void CloseMenu()
    {   
        _rectangles[0].SetActive(true);
        _rectangles[1].SetActive(false);
        MenuOpened = false;
    }


}
