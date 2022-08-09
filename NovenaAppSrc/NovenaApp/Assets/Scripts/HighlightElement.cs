using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class HighlightElement : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    [SerializeField]
    private GameObject[] _graphics, _texts;
    [SerializeField]
    private ColorType _highlightColor;
    [SerializeField]
    private ColorType _defaultColor;

    public void OnPointerEnter(PointerEventData eventData) 
    {
         ChangeColor(_graphics,true,_highlightColor);
         ChangeColor(_texts,false,_highlightColor);
    }
 
    public void OnPointerExit(PointerEventData eventData) 
    {
            ChangeColor(_graphics,true,_defaultColor);
            ChangeColor(_texts,false,_defaultColor);
    }

    void ChangeColor(GameObject[] fieldType, bool isGraphic, ColorType newColor)
    {
        Color colorToUse = ChooseColorType(newColor);
        foreach(GameObject single in fieldType)
        {   
            if(isGraphic)
            {
                single.gameObject.GetComponent<SpriteRenderer>().color = colorToUse;
            }
            else
            {
                single.gameObject.GetComponent<Text>().color = colorToUse;
            }
        }
    }

    Color ChooseColorType(ColorType colorType)
    {
        switch(colorType)
        {
            case ColorType.WHITE:
                return Color.white;
            case ColorType.BLACK:
                return Color.black;
            case ColorType.GREY:
                return Color.grey;
            default:
                return Color.white;
    
        }
    }

}

public enum ColorType
{
    WHITE,
    GREY,
    BLACK
}
