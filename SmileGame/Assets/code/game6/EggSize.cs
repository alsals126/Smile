using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class EggSize : MonoBehaviour, IPointerEnterHandler
{
    [SerializeField] float scaleSpeed = 1f;
    private GameObject target;
    NextStagePanel nsp;

    public void OnPointerEnter(PointerEventData eventData)
    {
        if (Input.touchCount == 2)
        {
            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Moved)
            {
                transform.localScale = new Vector3(
                transform.localScale.x - 1f * scaleSpeed * Time.deltaTime,
                transform.localScale.y - 1f * scaleSpeed * Time.deltaTime, 0);
            }
        }
    }
   
    void Update()
    {
        RectTransform rt = gameObject.GetComponent<RectTransform>();

        float width = rt.rect.width;
        float height = rt.rect.height;
        if(width<=0.5f && height <= 0.5f)
        {
            nsp = FindObjectOfType<NextStagePanel>();
            nsp.NextPanel();
        }
    }

    private void OnMouseDrag()
    {
        Vector3 mousePosition
        = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10);
        //마우스 좌표를 스크린 투 월드로 바꾸고 이 객체의 위치로 설정해 준다.
        this.transform.position = Camera.main.ScreenToWorldPoint(mousePosition);
    }
}
