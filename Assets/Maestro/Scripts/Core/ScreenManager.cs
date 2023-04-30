using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UIManaging;
using DG.Tweening;

[System.Serializable]
public class SaveBeforeScreenInfo
{
    public GameObject BeforeContent;
    public GameObject CurrentContent;
    public ChangeDirection currentContentActiveDir;
}

public class ScreenManager : MonoBehaviour
{
    public static ScreenManager Instance;
    public Vector3[] directionPos;
    private GameObject _renderingCanvas;

    public SaveBeforeScreenInfo beforeInfo;
    private void Awake()
    {
        if(Instance != null)
        {
            Debug.LogError("Error! ScreenManager Is Multyplying Working!");
            return;
        }
        Instance = this;
        DontDestroyOnLoad(this);
        _renderingCanvas = GameObject.Find("RenderingCanvas");
        beforeInfo = new SaveBeforeScreenInfo();
    }

    public void ScreenChange(GameObject content, ChangeDirection toMoveDir, float time)
    {
        if (toMoveDir != ChangeDirection.center)
            beforeInfo.BeforeContent = content;
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
}
