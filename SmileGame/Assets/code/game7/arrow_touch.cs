using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

// https://m.blog.naver.com/PostView.nhn?blogId=inceleb&logNo=220685447126&proxyReferer=https:%2F%2Fwww.google.com%2F
public class arrow_touch : MonoBehaviour, IPointerDownHandler
{
    [SerializeField] private GameObject obj;
    Vector3 pos;
    private float x, y;
    private void Start()
    {
        obj.transform.position = new Vector3(-2, 0.7f, 0); //처음 위치 설정
        setPosition();
    }
    private void Update()
    {
        pos = this.gameObject.transform.position;
        setX(pos.x);
        setY(pos.y);
    }
    private void setPosition()
    {
        
    }
    private void setX(float posX)  { x = posX; }
    private void setY(float posY) { y = posY; }
    private float getX() { return x; }
    private float getY() { return y; }

    public void right(){ setPosition();  obj.transform.position = new Vector3(getX() + 0.01f, getY(), 0); }
    public void left() { setPosition(); obj.transform.position = new Vector3(getX() - 1, getY(), 0); }
    public void down() { setPosition(); obj.transform.position = new Vector3(getX(), getY() - 1, 0); }
    public void up() { setPosition(); obj.transform.position = new Vector3(getX(), getY() + 1, 0); }

    public void OnPointerDown(PointerEventData eventData)
    {
        setPosition(); obj.transform.position = new Vector3(getX() + 0.01f, getY(), 0);
    }
}
