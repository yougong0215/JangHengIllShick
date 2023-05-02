using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestContent : MonoBehaviour
{
    [SerializeField] private GameObject _questBtnManager;
    [SerializeField] private GameObject _ingQuestManager;

    public bool ingQuest;

    public void SetScreen()
    {
        _questBtnManager.SetActive(!ingQuest);
        _ingQuestManager.SetActive(ingQuest);
    }
}
