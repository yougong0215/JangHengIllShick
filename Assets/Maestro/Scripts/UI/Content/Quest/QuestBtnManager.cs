using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using QuestType;

public class QuestBtnManager : MonoBehaviour
{
    [SerializeField] private List<GameObject> _questBtnList = new List<GameObject>();
    
    [SerializeField] private GameObject _questTypeImage;
    private void Start()
    {
        if(QuestManager.Instance.questSaveInfo.unSave)
        {
            int currentNumber = Random.Range(0, QuestManager.Instance.questSOList.Count);
            List<int> shuffle = new List<int>();
            for (int i = 0; i < QuestManager.Instance.questSOList.Count;)
            {
                if (shuffle.Contains(currentNumber))
                {
                    currentNumber = Random.Range(0, QuestManager.Instance.questSOList.Count);
                }
                else
                {
                    shuffle.Add(currentNumber);
                    i++;
                }
            }

            for(int i = 0; i < shuffle.Count; i++)
            {
                QuestButton qb = _questBtnList[i].GetComponent<QuestButton>();
                qb.questSo = QuestManager.Instance.questSOList[shuffle[i]];
                qb.SetName();
            }

            QuestManager.Instance.questSaveInfo.unSave = false;
        }
        else
        {
            for(int i = 0; i < 3; i++)
            {
                QuestButton qbtn = _questBtnList[i].GetComponent<QuestButton>();
                qbtn.questSo = QuestManager.Instance.questSaveInfo.saveList[i];
                qbtn.SetName();
            }
        }
    }

}
