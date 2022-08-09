using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Gallery.Model
{
    [CreateAssetMenu]
    public class GallerySO : ScriptableObject
    {
        private GameObject[] _galleryItems;
        public string currentSelectedItem;
    }
}
