using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UIManaging;

public class ManagementMenuBtn : ButtonBase
{
    [SerializeField] private List<GameObject> _quantitiyContent = new List<GameObject>();

    public override void ClickBtn()
    {
        
    }

    public void NextScreen(int num)
    {
        base.ClickUnActive();
        GameObject roboqua = ScreenManager.Instance.CreateContent(_quantitiyContent[num], ChangeDirection.right);
        GameObject eleMa = GameObject.Find("ElementManagementContent");
        ScreenManager.Instance.ScreenChange(roboqua, ChangeDirection.center, 0.5f);
        ScreenManager.Instance.ScreenChange(eleMa, ChangeDirection.left, 0.5f);

        ActiveFasle(eleMa);
    }
}
