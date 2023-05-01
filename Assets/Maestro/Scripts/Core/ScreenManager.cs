using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UIManaging;
using DG.Tweening;

[System.Serializable]
public class SaveBeforeScreenInfo
{
    public List<GameObject> BeforeContentList = new List<GameObject>();
    public GameObject CurrentContent;
    public ChangeDirection currentContentActiveDir;
}

public class ScreenManager : MonoBehaviour
{
    public static ScreenManager Instance;
    public bool canclick;
    public Vector3[] directionPos;
    private GameObject _renderingCanvas;

    public SaveBeforeScreenInfo beforeInfo;
    [SerializeField] private GameObject EventSystem;
    private void Awake()
    {
        if(Instance != null)
        {
            Debug.LogError("Error! ScreenManager Is Multyplying Working!");
            return;
        }
        Instance = this;
        DontDestroyOnLoad(this);
        canclick = true;
        _renderingCanvas = GameObject.Find("RenderingCanvas");
        beforeInfo = new SaveBeforeScreenInfo();
    }

    public void ScreenChange(GameObject content, ChangeDirection toMoveDir, float time)
    {
        if (toMoveDir != ChangeDirection.center)
            beforeInfo.BeforeContentList.Add(content);
        else
        {
            beforeInfo.CurrentContent = content;
        }
        content.transform.DOLocalMove(directionPos[((int)toMoveDir)], time);
    }

    public GameObject CreateContent(GameObject content, ChangeDirection createPos)
    {
        GameObject conten = Instantiate(content, _renderingCanvas.transform);
        conten.name = conten.name.Replace("(Clone)", "");
        conten.transform.localPosition = directionPos[(int)createPos];
        beforeInfo.currentContentActiveDir = createPos;
        return conten;
    }

    public void ClickActive()
    {
        if(EventSystem.activeSelf)
        {
            EventSystem.SetActive(false);
        }
        else
        {
            EventSystem.SetActive(true);
        }
    }
}
