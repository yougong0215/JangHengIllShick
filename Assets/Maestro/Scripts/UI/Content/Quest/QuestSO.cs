using QuestType;
using UnityEngine;

[CreateAssetMenu(menuName = "SO/Quest/QuestData")]
public class QuestSO : ScriptableObject
{
    public string QuestName;
    public string QuestInfo;
    public QType qType;
    public GameObject screenPrefab;
}
