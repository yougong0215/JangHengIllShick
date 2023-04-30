using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UIManaging;
using System;

public abstract class LobyBottomBtn : MonoBehaviour
{
    public abstract void ClickBtn();

    protected void ActiveFasle(GameObject loby)
    {
        StartCoroutine(ActiveFalseCoroutine(loby));
    }

    IEnumerator ActiveFalseCoroutine(GameObject loby)
    {
        yield return new WaitForSeconds(0.5f);
        loby.SetActive(false);
    }
}
