using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RobotPartsInfo : MonoBehaviour
{
    [SerializeField] private PartsSo _partsSo;

    public void ClickThisParts()
    {
        PartsInfoPanel _paenl = transform.parent.GetComponent<PartsInfoPanel>();
        _paenl.SetPanel(_partsSo.partsImage, _partsSo.partsname, _partsSo.atk, _partsSo.def, _partsSo.info);
    }
}
