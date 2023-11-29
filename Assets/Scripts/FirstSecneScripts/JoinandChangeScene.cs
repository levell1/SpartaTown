using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class JoinandChangeScene : MonoBehaviour
{
    [SerializeField] private TMP_Text ChangeArea;
    [SerializeField] private Button JoinButton;

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
    private void ChangeScene() 
    {

        PlayerPrefs.SetString("name", ChangeArea.text);      
        SceneManager.LoadScene("SampleScene");
    }
}
