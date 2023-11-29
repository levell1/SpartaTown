using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneSetting : MonoBehaviour
{
    [SerializeField] private GameObject zep;
    [SerializeField] private GameObject postit;
    // Start is called before the first frame update
    private void Awake()
    {
        GameManager.Instance.zep = zep;
        GameManager.Instance.postit = postit;
    }

}
