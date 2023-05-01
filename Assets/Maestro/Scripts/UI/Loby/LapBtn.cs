using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UIManaging;

public class LapBtn : ButtonBase
{
    [SerializeField] private GameObject _lapContent;
    public override void ClickBtn()
    {
        base.ClickUnActive();
        GameObject ele = ScreenManager.Instance.CreateContent(_lapContent, ChangeDirection.right);
        GameObject loby = GameObject.Find("LobyContent");
        ScreenManager.Instance.ScreenChange(ele, ChangeDirection.center, 0.5f);
        ScreenManager.Instance.ScreenChange(loby, ChangeDirection.left, 0.5f);

        ActiveFasle(loby);
    }
}
