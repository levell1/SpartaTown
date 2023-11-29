
using UnityEngine;

public class ChangePlayer : MonoBehaviour
{
    public int playernum;
    [SerializeField] private GameObject label;
    [SerializeField] private GameObject player0View;
    [SerializeField] private GameObject player1View;

    private void Awake()
    {
        playernum = 0;
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
        GameManager.Instance.ChangePlayer();

    }
    private void SelectPlayer1()
    {
        playernum = 1;
        PlayerPrefs.SetInt("player", playernum);
        label.SetActive(false);
        player0View.SetActive(false);
        player1View.SetActive(true);
        GameManager.Instance.ChangePlayer();
    }

}
