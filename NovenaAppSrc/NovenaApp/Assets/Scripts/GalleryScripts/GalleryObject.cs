using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Gallery.Model;

public class GalleryObject : MonoBehaviour
{
    [SerializeField]
    private GameObject _overlayMenu,_nameObject,_imageObject;
    [SerializeField]
    private GallerySO _gallery;

    public void SelectItem()
    {
        if(_gallery.currentSelectedItem == "" && !MenuButtonController.MenuOpened)
        {
            _gallery.currentSelectedItem = _nameObject.GetComponent<Text>().text;
            _imageObject.SetActive(false);
            _overlayMenu.SetActive(true);
            this.gameObject.SetActive(true);
        }
    }

    public void EnlargePicture()
    {
        GalleryContentController.ShowImagePanel = true;
    }

    public void DeselectItem()
    {
        _gallery.currentSelectedItem = "";
        _imageObject.SetActive(true);
        _overlayMenu.SetActive(false);
    }
}
