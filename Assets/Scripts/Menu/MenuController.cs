using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuController : MonoBehaviour
{
    public GameObject UserList;
    public GameObject MenuBar;
    // Start is called before the first frame update

    private void Awake()
    {
        UserList.SetActive(false);
        MenuBar.SetActive(true);
    }
    public void exitMenu()
    {
        MenuBar.SetActive(true);
        UserList.SetActive(false);
    }

    public void ViewMenu()
    {
        MenuBar.SetActive(false);
        UserList.SetActive(true);
    }
}
