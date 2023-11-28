using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class ChangeID : MonoBehaviour
{
    public TMP_Text ChangeArea;
    public TMP_Text ChangeNname;
    public TMP_Text ChangeNname1;
    public GameObject label;

    public void changeName()
    {
        PlayerPrefs.SetString("name", ChangeArea.text);
        ChangeNname.text = ChangeArea.text;
        ChangeNname1.text = ChangeArea.text;
        label.SetActive(false);
    }
    public void ViewChangeID()
    {
        ChangeArea.text = PlayerPrefs.GetString("name");
        label.SetActive(true);
    }
}
