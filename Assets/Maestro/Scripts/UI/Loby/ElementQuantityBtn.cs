using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UIManaging;

public class ElementQuantityBtn : ButtonBase
{
    [SerializeField] private GameObject _eleQuanContent;
    public override void ClickBtn()
    {
        base.ClickUnActive();
        GameObject ele = ScreenManager.Instance.CreateContent(_eleQuanContent, ChangeDirection.right);
        GameObject loby = GameObject.Find("LobyContent");
        ScreenManager.Instance.ScreenChange(ele, ChangeDirection.center, 0.5f);
        ScreenManager.Instance.ScreenChange(loby, ChangeDirection.left, 0.5f);

        ActiveFasle(loby);
    }
}
