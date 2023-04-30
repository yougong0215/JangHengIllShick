using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public struct PartsInfo
{
    public string partsName;
    public GameObject partsPrefab;
    public Sprite partsSprite;
}

public class PartsImageProduce : MonoBehaviour
{
    [SerializeField] private List<PartsInfo> partsList = new List<PartsInfo>();
    [SerializeField] private GameObject _content;
    private void Start()
    {
        RectTransform _contentRect = _content.GetComponent<RectTransform>();
        _content.transform.localScale = new Vector2(0, 0);
        float scaleX = 0;
        for(int i = 0; i < partsList.Count; i++)
        {
            if (i > 1)
            {
                scaleX += -300;
                _contentRect.transform.localScale = new Vector2(scaleX, 0);
            }
            Instantiate(partsList[i].partsPrefab, _content.transform);
        }

        _contentRect.transform.localPosition = new Vector3(0, 0, 0);
    }
}
