using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enter : MonoBehaviour
{
    [SerializeField] private InputField input;
    [SerializeField] private string text1;

    
    public void enterButton() 
    {
        if(input.text == text1)
        {
            GameObject.Find("Main Camera").GetComponent<NextStagePanel>().NextPanel();
        }
        else
        {
            input.SetTextWithoutNotify("");
        }
    }   
}
