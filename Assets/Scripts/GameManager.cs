using UnityEngine;

public class GameManager : MonoBehaviour
{

    [SerializeField] private GameObject zep;
    [SerializeField] private GameObject postit;

    private static GameManager instance = null;

    public static GameManager Instance
    {
        get 
        {
            if (instance == null)
            {
                return null;
            }
            return instance;
        }
    }
    private void Awake()
    {
        if (null == instance)
        {
            instance = this;

            DontDestroyOnLoad(this.gameObject);
        }
        else { 
            Destroy(this.gameObject);
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
