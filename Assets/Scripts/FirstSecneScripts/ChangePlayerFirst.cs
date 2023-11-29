using UnityEngine;

public class ChangePlayerFirst : MonoBehaviour
{
    
    private int playernum = 0;
    [SerializeField]    private GameObject label;
    [SerializeField]    private GameObject player0View;
    [SerializeField]    private GameObject player1View;

    private void Awake()
    {
        PlayerPrefs.SetInt("player", playernum);
    }
    private void OpenLabel() 
    {
        label.SetActive(true);
    }
    private void SelectPlayer0() 
    {
        playernum = 0;
        PlayerPrefs.SetInt("player", playernum);
        label.SetActive(false);
        player0View.SetActive(true);
        player1View.SetActive(false);
    }
    private void SelectPlayer1()
    {
        playernum = 1;
        PlayerPrefs.SetInt("player", playernum);
        label.SetActive(false);
        player0View.SetActive(false);
        player1View.SetActive(true);
    }

}
