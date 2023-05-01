using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UIManaging;


public class MaterialSupplyBtn : ButtonBase
{
    [SerializeField] private GameObject _materialSupplyContent;
    public override void ClickBtn()
    {
        GameObject mat = ScreenManager.Instance.CreateContent(_materialSupplyContent, ChangeDirection.right);
        GameObject loby = GameObject.Find("LobyContent");
        ScreenManager.Instance.ScreenChange(mat, ChangeDirection.center, 0.5f);
        ScreenManager.Instance.ScreenChange(loby, ChangeDirection.left, 0.5f);

        ActiveFasle(loby);
    }
}
