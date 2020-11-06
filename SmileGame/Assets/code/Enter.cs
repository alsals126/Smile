using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Enter : MonoBehaviour
{
    [SerializeField] private InputField input_plz;
    [SerializeField] private string sceneName;
    [SerializeField] private string text1;

    public void enterButton()
    {
        if(input_plz.text == text1)
        {
            MoveScene();
        }
    }
    public void MoveScene()
    {
        SceneManager.LoadScene(sceneName);
    }
}
