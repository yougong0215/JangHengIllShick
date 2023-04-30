using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UIManaging;
using DG.Tweening;

public class BackBtn : MonoBehaviour
{
    public void Back()
    {
        //ChangeDirection dir = ChangeDirection.center;

        //switch(ScreenManager.Instance.beforeInfo.currentContentActiveDir)
        //{
        //    case ChangeDirection.up:
        //        dir = ChangeDirection.down;
        //        break;
        //    case ChangeDirection.down:
        //        dir = ChangeDirection.up;
        //        break;
        //    case ChangeDirection.right:
        //        dir = ChangeDirection.left;
        //        break;
        //    case ChangeDirection.left:
        //        dir = ChangeDirection.right;
        //        break;
        //    default:
        //        break;
               
        //}

        ScreenManager.Instance.beforeInfo.BeforeContent.SetActive(true);

        ScreenManager.Instance.beforeInfo.BeforeContent.transform.DOLocalMove(
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
    }
}
