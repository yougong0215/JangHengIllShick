using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LobyBottomContainer : MonoBehaviour
{
    [SerializeField] private List<GameObject> _bottomBtnList = new List<GameObject>();

    private void Start()
    {
        GameObject botContainer = GameObject.Find("BottombtnContainer");
        for (int i = 0; i < _bottomBtnList.Count; i++)
        {
            GameObject btn = Instantiate(_bottomBtnList[i], botContainer.transform);
            btn.name = btn.name.Replace("(Clone)", "");
        }
    }
}
