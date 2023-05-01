using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UIManaging;

public class FactoryBtn : ButtonBase
{
    [SerializeField] private GameObject _matCliker;
    public override void ClickBtn()
    {
        GameObject matClicker = ScreenManager.Instance.CreateContent(_matCliker, ChangeDirection.right);
        GameObject mat = GameObject.Find("MaterialSupplyContent");
        ScreenManager.Instance.ScreenChange(matClicker, ChangeDirection.center, 0.5f);
        ScreenManager.Instance.ScreenChange(mat, ChangeDirection.left, 0.5f);

        ActiveFasle(mat);
    }
}
