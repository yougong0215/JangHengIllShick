using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UIManaging;

public class BuildRobotBtn : LobyBottomBtn
{
    [SerializeField] private GameObject _buildRobotContent;
    public override void ClickBtn()
    {
        GameObject robot = ScreenManager.Instance.CreateContent(_buildRobotContent, ChangeDirection.right);
        GameObject loby = GameObject.Find("LobyContent");
        ScreenManager.Instance.ScreenChange(robot, ChangeDirection.center, 0.5f);
        ScreenManager.Instance.ScreenChange(loby, ChangeDirection.left, 0.5f);

        ActiveFasle(loby);
    }
}
