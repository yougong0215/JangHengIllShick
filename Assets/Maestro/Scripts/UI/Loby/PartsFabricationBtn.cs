using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UIManaging;

public class PartsFabricationBtn : LobyBottomBtn
{
    [SerializeField] private GameObject _partsFabContent;
    public override void ClickBtn()
    {
        GameObject parts = ScreenManager.Instance.CreateContent(_partsFabContent, ChangeDirection.right);
        GameObject loby = GameObject.Find("LobyContent");
        ScreenManager.Instance.ScreenChange(parts, ChangeDirection.center, 0.5f);
        ScreenManager.Instance.ScreenChange(loby, ChangeDirection.left, 0.5f);

        ActiveFasle(loby);
    }
}
