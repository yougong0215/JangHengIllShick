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
            List<QuestSO> _secondSoList = QuestManager.Instance.questSOList;
            for (int i = 0; i < _questBtnList.Count; i++)
            {
                int soRand = Random.Range(0, _secondSoList.Count);

                QuestButton qbtn = _questBtnList[i].GetComponent<QuestButton>();
                qbtn.questSo = _secondSoList[soRand];
                QuestManager.Instance.questSOList[i] = _secondSoList[soRand];
                qbtn.SetName();
                _secondSoList.RemoveAt(soRand);
            }

            QuestManager.Instance.questSaveInfo.unSave = false;
        }
        else
        {
            for(int i = 0; i < 3; i++)
            {
                QuestButton qbtn = _questBtnList[i].GetComponent<QuestButton>();
                qbtn.questSo = QuestManager.Instance.questSOList[i];
                qbtn.SetName();
            }
        }
    }

}
