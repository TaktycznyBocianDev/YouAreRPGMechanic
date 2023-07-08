using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Slots : MonoBehaviour, IDropHandler
{
    private bool ocupate = false;

    public void OnDrop(PointerEventData eventData)
    {
        if (!ocupate)
        {
            if (eventData.pointerDrag != null)
            {
                eventData.pointerDrag.GetComponent<RectTransform>().SetParent(GetComponent<RectTransform>());
                eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = new Vector3(0, 0, 0);
                ocupate = true;

            }
        }     
    }
}
