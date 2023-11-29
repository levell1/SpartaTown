using UnityEngine;

public class MenuController : MonoBehaviour
{
    [SerializeField] private GameObject UserList;
    [SerializeField] private GameObject MenuBar;
    // Start is called before the first frame update

    private void Awake()
    {
        UserList.SetActive(false);
        MenuBar.SetActive(true);
    }
    private void exitMenu()
    {
        MenuBar.SetActive(true);
        UserList.SetActive(false);
    }

    private void ViewMenu()
    {
        MenuBar.SetActive(false);
        UserList.SetActive(true);
    }
}
