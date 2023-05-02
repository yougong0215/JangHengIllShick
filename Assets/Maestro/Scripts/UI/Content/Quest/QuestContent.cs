using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using QuestType;

public class QuestContent : MonoBehaviour
{
    [SerializeField] private GameObject _questBtnManager;
    [SerializeField] private GameObject _ingQuestManager;

    public bool ingQuest;

    public void SetScreen()
    {
        _questBtnManager.SetActive(!ingQuest);
        _ingQuestManager.SetActive(ingQuest);

        if(ingQuest)
        {
            if(QuestManager.Instance.selectQuest.qType == QType.Battle)
            {
                _ingQuestManager.transform.Find("BattleQuestContent").gameObject?.SetActive(true);
                _ingQuestManager.transform.Find("DelieveryQuestContent").gameObject?.SetActive(false);
            }
            else if(QuestManager.Instance.selectQuest.qType == QType.Delivery)
            {
                _ingQuestManager.transform.Find("BattleQuestContent").gameObject?.SetActive(false);
                _ingQuestManager.transform.Find("DelieveryQuestContent").gameObject?.SetActive(true);
            }
        }
    }
}
