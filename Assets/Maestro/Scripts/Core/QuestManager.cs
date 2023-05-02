using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class SaveQuestInfo
{
    public bool unSave;
    public List<QuestSO> saveList = new List<QuestSO>();
}

public class QuestManager : MonoBehaviour
{
    public static QuestManager Instance;
    public List<QuestSO> questSOList = new List<QuestSO>();
    public SaveQuestInfo questSaveInfo;
    public QuestSO selectQuest;

    public bool isIngQuest;
    private void Awake()
    {
        if(Instance != null)
        {
            Debug.LogError("Warning! QuestManager Already Instancing!!");
        }
        Instance = this;
        questSaveInfo = new SaveQuestInfo();
        questSaveInfo.unSave = true;
        DontDestroyOnLoad(this);
    }

    
}
