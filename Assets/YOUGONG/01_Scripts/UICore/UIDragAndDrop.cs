using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class UIDragAndDrop : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IEndDragHandler, IDragHandler, IDropHandler
{

    RectTransform rectTransform;
    CanvasGroup canvasGroup;
    [SerializeField] Canvas canvas;
    private void Awake()
    {
        canvas = transform.parent.parent.parent.GetComponentInParent<Canvas>();

        rectTransform = GetComponent<RectTransform>();
        canvasGroup = GetComponent<CanvasGroup>();
    }


    public void OnBeginDrag(PointerEventData eventData)
    {
        transform.parent = canvas.transform;
        canvasGroup.alpha = .6f;
        canvasGroup.blocksRaycasts = false;
    }

    public void OnDrag(PointerEventData eventData)
    {
        // 이전 이동과 비교해서 얼마나 이동했는지를 보여줌
        // 캔버스의 스케일과 맞춰야 하기 때문에
        rectTransform.anchoredPosition += eventData.delta / canvas.scaleFactor;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        canvasGroup.alpha = 1f;
        canvasGroup.blocksRaycasts = true;

        if(UISlotManager.Instance.SoltUI)
        {
            transform.parent = UISlotManager.Instance.SoltUI.transform;
            transform.position = UISlotManager.Instance.SoltUI.transform.position;

            UISlotManager.Instance.NullUIS();

            Destroy(this);
        }
        else
        {
            Destroy(gameObject);
        }

    }

    public void OnPointerDown(PointerEventData eventData)
    {

    }

    public void OnDrop(PointerEventData eventData)
    {

    }
}