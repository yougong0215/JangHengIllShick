using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UIManaging;
using System;

public abstract class ButtonBase : MonoBehaviour
{
    public abstract void ClickBtn();

    protected void ActiveFasle(GameObject loby)
    {
        StartCoroutine(ActiveFalseCoroutine(loby));
    }

    protected virtual void ClickUnActive()
    {
        ScreenManager.Instance.ClickActive();
    }

    IEnumerator ActiveFalseCoroutine(GameObject loby)
    {
        yield return new WaitForSeconds(0.5f);
        ScreenManager.Instance.ClickActive();
        loby.SetActive(false);
        //Destroy(loby);
    }
}
