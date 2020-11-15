using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hint : MonoBehaviour
{
    [SerializeField] private GameObject panel;
    [SerializeField] private Button button;

    private void Start()
    {
        panel.gameObject.SetActive(false);
    }

    private void OnMouseDown()
    {
        GameObject next = GameObject.Find("NextStage");
        if(next.gameObject.activeSelf == false)
        {
            panel.gameObject.SetActive(true);
        }
        button.onClick.AddListener(ButtonClicked);
    }
    void ButtonClicked()
    {
        panel.gameObject.SetActive(false);
    }
}
