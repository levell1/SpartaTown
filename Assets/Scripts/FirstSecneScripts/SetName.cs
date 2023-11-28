using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class SetName : MonoBehaviour
{

    public TMP_Text _PlayerName;
    public string KeyWord;
    private void Awake()
    {
        _PlayerName = GetComponent<TMP_Text>();
        Name();
    }
    public void Name()
    {

        _PlayerName.text = PlayerPrefs.GetString(KeyWord);
    }
    private void Update()
    {
        Name();
    }
}
