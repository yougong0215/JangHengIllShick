using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UIManaging;
using DG.Tweening;

public class BackBtn : MonoBehaviour
{
    public void Back()
    {
        ScreenManager.Instance.beforeInfo.BeforeContentList
            [ScreenManager.Instance.beforeInfo.BeforeContentList.Count - 1].SetActive(true);

        ScreenManager.Instance.beforeInfo.BeforeContentList
            [ScreenManager.Instance.beforeInfo.BeforeContentList.Count - 1].transform.DOLocalMove(
                      ScreenManager.Instance.directionPos[(int)ChangeDirection.center],
                                                        0.5f);

        ScreenManager.Instance.beforeInfo.CurrentContent.transform.DOLocalMove(
                      ScreenManager.Instance.directionPos[(int)ScreenManager.Instance.beforeInfo.currentContentActiveDir], 0.5f);

        

        
        StartCoroutine(ActiveFalse(ScreenManager.Instance.beforeInfo.CurrentContent));
    }

    IEnumerator ActiveFalse(GameObject currentScreen)
    {
        yield return new WaitForSeconds(0.5f);
        currentScreen.SetActive(false);
        ScreenManager.Instance.beforeInfo.CurrentContent = ScreenManager.Instance.beforeInfo.BeforeContentList
        [ScreenManager.Instance.beforeInfo.BeforeContentList.Count - 1];
        ScreenManager.Instance.beforeInfo.BeforeContentList.RemoveAt(ScreenManager.Instance.beforeInfo.BeforeContentList.Count - 1);
    }
}
