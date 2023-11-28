using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class JoinandChangeScene : MonoBehaviour
{

    public TMP_Text ChangeArea;
    public Button JoinButton;

    private void Update()
    {
        if (4 > ChangeArea.text.Length || ChangeArea.text.Length > 10) 
        {
            JoinButton.interactable = false;
        }else 
        {
            JoinButton.interactable = true;
        }
    }
    public void ChangeScene() 
    {

        PlayerPrefs.SetString("name", ChangeArea.text);      
        SceneManager.LoadScene("SampleScene");
    }
}
