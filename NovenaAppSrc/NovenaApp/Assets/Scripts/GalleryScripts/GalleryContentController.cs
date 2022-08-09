using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Gallery.Model;

public class GalleryContentController : MonoBehaviour
{
    [SerializeField]
    private GallerySO _gallery;
    [SerializeField]
    private GameObject _pageTitle, _selectRectangleMark,_imagePanel;
    public GameObject GalleryItemPrefab;
    public TextAsset textJSON;
    public static bool ShowImagePanel;

    [SerializeField]
    public Sprite defaultSprite;

    [System.Serializable]
    public struct GalleryItem
    {
        public string Name;
        public string IconLocation;
        public Sprite Icon;
    }

    public void DisplayImage()
    {
        string objectName = _gallery.currentSelectedItem;
        _imagePanel.SetActive(true);
        _imagePanel.gameObject.transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>().sprite = GameObject.Find(objectName).gameObject.transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>().sprite;
    }

    public void CloseImagePanel()
    {
        ShowImagePanel = false;
    }

    [SerializeField] GalleryItem[] _allItems;

    void Start() 
    {
        ShowImagePanel = false;
        _gallery.currentSelectedItem = "";
        StartCoroutine(GetGalleryItems());
    }

    IEnumerator GetGalleryItems()
    {
        _allItems = JsonHelper.GetArray<GalleryItem>(textJSON.text);
        StartCoroutine(GetGalleryItemsImages());
        yield return new WaitForSeconds(0.0f);
    }

    IEnumerator GetGalleryItemsImages()
    {
        for(int i=0; i < _allItems.Length; i++)
        {
            string path = _allItems[i].IconLocation;
            _allItems[i].Icon = Resources.Load<Sprite>(path);
        } 
        DrawUI();
        yield return new WaitForSeconds(0.0f);
    }

    void DrawUI()
    {
        for(int i=0; i < _allItems.Length; i++)
        {
            GameObject item = Instantiate (GalleryItemPrefab,transform);
            item.gameObject.transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>().sprite = _allItems[i].Icon;
            item.gameObject.transform.GetChild(2).gameObject.transform.GetChild(2).gameObject.GetComponent<Text>().text = _allItems[i].Name;
            item.name = _allItems[i].Name;
        }
    }

    void Update()
    {
        if(_gallery.currentSelectedItem == "")
        {
            _pageTitle.gameObject.GetComponent<Text>().color = Color.white;
            _selectRectangleMark.SetActive(false);
        }
        else
        {
            _pageTitle.gameObject.GetComponent<Text>().color = Color.black;
            _selectRectangleMark.SetActive(true);
        }

        switch(ShowImagePanel)
        {
            case true:
                DisplayImage();
                break;
            case false:
                _imagePanel.SetActive(false);
                break;
            default:
                _imagePanel.SetActive(false);
                break;
        }
    }


}
