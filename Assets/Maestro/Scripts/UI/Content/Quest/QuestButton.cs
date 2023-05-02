using UnityEngine;
using TMPro;
using UIManaging;

public class QuestButton : ButtonBase
{
    public QuestSO questSo;
    [SerializeField] private GameObject _questcheckContent;
    public void SetName()
    {
        TextMeshProUGUI name = GetComponentInChildren<TextMeshProUGUI>();
        name.SetText(questSo.QuestName);
    }

    public override void ClickBtn()
    {
        base.ClickUnActive();
        QuestContent _qc = GameObject.Find("QuestContent").GetComponent<QuestContent>();
        _qc.ingQuest = true;
        QuestManager.Instance.selectQuest = questSo;
        GameObject ele = ScreenManager.Instance.CreateContent(_questcheckContent, ChangeDirection.right);
        GameObject QC = GameObject.Find("QuestContent");
        ScreenManager.Instance.ScreenChange(ele, ChangeDirection.center, 0.5f);
        ScreenManager.Instance.ScreenChange(QC, ChangeDirection.left, 0.5f);

        ActiveFasle(QC);
    }
}
