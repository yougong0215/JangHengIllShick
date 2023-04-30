using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UIManaging;

public class QuestBtn : LobyBottomBtn
{
    [SerializeField] private GameObject _questContent;
    public override void ClickBtn()
    {
        GameObject ques = ScreenManager.Instance.CreateContent(_questContent, ChangeDirection.right);
        GameObject loby = GameObject.Find("LobyContent");
        ScreenManager.Instance.ScreenChange(ques, ChangeDirection.center, 0.5f);
        ScreenManager.Instance.ScreenChange(loby, ChangeDirection.left, 0.5f);

        ActiveFasle(loby);
    }
}
