using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class GameManager : MonoBehaviour
{
    int playernum = 0;
    public GameObject zep;
    public GameObject postit;

    private static GameManager instance = null;
    private void Awake()
    {
        if (null == instance)
        {

            instance = this;

            DontDestroyOnLoad(this.gameObject);
        }
        
    }
    private void Start()
    {
        ChangePlayer();
    }
    public void ChangePlayer() {
        if (PlayerPrefs.GetInt("player") == 0)
        {
            zep.SetActive(true);
            postit.SetActive(false);
        }
        else if (PlayerPrefs.GetInt("player") == 1)
        {
            zep.SetActive(false);
            postit.SetActive(true);
        }

    }
}
