using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class arrow_touch : MonoBehaviour
{
    private GameObject obj;
    Vector3 pos;
    private float x, y;
    private void Start()
    {
        pos = this.gameObject.transform.position;
        setX(pos.x);
        setY(pos.y);
    }
    private void setX(float posX)  { x = posX; }
    private void setY(float posY) { x = posY; }
    public void OnMouseDown()
    {
        obj.transform.position = new Vector3(0, 0, 0);
    }

}
