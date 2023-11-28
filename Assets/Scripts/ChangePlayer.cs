using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ChangePlayer : MonoBehaviour
{
    public int playernum;
    public GameObject label;
    public GameObject player0View;
    public GameObject player1View;
    public GameManager gameManager;

    private void Awake()
    {
        playernum = 0;
    }
    public void OpenLabel() 
    {
        label.SetActive(true);
    }
    public void SelectPlayer0() 
    {
        playernum = 0;
        PlayerPrefs.SetInt("player", playernum);
        label.SetActive(false);
        player0View.SetActive(true);
        player1View.SetActive(false);
        gameManager.ChangePlayer();
    }
    public void SelectPlayer1()
    {
        playernum = 1;
        PlayerPrefs.SetInt("player", playernum);
        label.SetActive(false);
        player0View.SetActive(false);
        player1View.SetActive(true);
        gameManager.ChangePlayer();
    }

}
