using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SetName : MonoBehaviour
{
    [SerializeField] private TMP_Text _PlayerName;
    [SerializeField] private string KeyWord;
    private void Awake()
    {
        _PlayerName = GetComponent<TMP_Text>();
        Name();
    }
    private void Name()
    {
        _PlayerName.text = PlayerPrefs.GetString(KeyWord);
    }
    private void Update()
    {
        Name();
    }
}
