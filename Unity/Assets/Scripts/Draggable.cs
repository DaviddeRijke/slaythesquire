using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Draggable : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    public Transform parentReturn = null;
    public GameObject placeholder;
    private Vector3 targetPos;

    public void Update()
    {
        if (targetPos != Vector3.zero)
        {
            transform.position = Vector3.Lerp(transform.position, targetPos, 0.3f);
        }
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        placeholder = new GameObject();
        placeholder.transform.SetParent(transform.parent);
        placeholder.transform.SetSiblingIndex(transform.GetSiblingIndex());

        GetComponent<CanvasGroup>().blocksRaycasts = false;
        parentReturn = transform.parent;
        transform.SetParent(transform.parent.parent);
    }

    public void OnDrag(PointerEventData eventData)
    {
        targetPos = eventData.position;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        GetComponent<CanvasGroup>().blocksRaycasts = true;
        targetPos = Vector3.zero;
        transform.SetParent(parentReturn);

        if (placeholder.transform.parent == parentReturn)
        {
            transform.SetSiblingIndex(placeholder.transform.GetSiblingIndex());
        }
        if (placeholder != null)
        {
            Destroy(placeholder);
        }
    }
}
