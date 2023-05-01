using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotScrollLook : MonoBehaviour
{
    [SerializeField] private GameObject _scroll;
    public void LookScroll()
    {
        Instantiate(_scroll, GameObject.Find("RobotQuantitiyContent").transform);
    }
}
