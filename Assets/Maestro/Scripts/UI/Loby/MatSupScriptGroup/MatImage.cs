using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class MatImage : MonoBehaviour
{
    Image thisImage;
    public void MovePos(Vector3 toPos)
    {
        thisImage = GetComponent<Image>();
        this.transform.DOLocalMove(toPos, 0.5f);
        StartCoroutine(FadeImage());
    }

    IEnumerator FadeImage()
    {
        yield return new WaitForSeconds(0.5f);
        float alpha = 1;
        while(alpha > 0)
        {
            yield return new WaitForSeconds(0.01f);
            thisImage.color = new Color(1, 1, 1, alpha);
            alpha -= 0.02f;
        }
        Destroy(this.gameObject);
    }
}
