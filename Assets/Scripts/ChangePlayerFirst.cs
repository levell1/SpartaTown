using UnityEngine;

public class ChangePlayerFirst : MonoBehaviour
{
    public int playernum = 0;
    public GameObject label;
    public GameObject player0View;
    public GameObject player1View;

    private void Awake()
    {
        PlayerPrefs.SetInt("player", playernum);
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
    }
    public void SelectPlayer1()
    {
        playernum = 1;
        PlayerPrefs.SetInt("player", playernum);
        label.SetActive(false);
        player0View.SetActive(false);
        player1View.SetActive(true);
    }

}
