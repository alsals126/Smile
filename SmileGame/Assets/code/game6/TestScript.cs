using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TestScript : MonoBehaviour, IPointerDownHandler, IPointerEnterHandler
{
    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log(transform.name);
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        Debug.Log("MouseOver");
    }
}
