using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProductPartsScroll : MonoBehaviour
{
    [SerializeField] private GameObject _partsTypeScroll;
    [SerializeField] private List<GameObject> _partsList = new List<GameObject>();

    public void ProduceScroll(int num)
    {
        GameObject robotCon = GameObject.Find("BuildRobotContent");
        if (GameObject.Find("PartsTypeScroll(Clone)"))
        {
            GameObject already = GameObject.Find("PartsTypeScroll(Clone)");
            Destroy(already);
        }
        GameObject scroll = Instantiate(_partsTypeScroll, robotCon.transform);

        
        Instantiate(_partsList[num], scroll.transform.Find("Viewport").transform);
    }
}
