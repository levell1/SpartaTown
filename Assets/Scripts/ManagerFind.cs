using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ManagerFind : MonoBehaviour
{
    [SerializeField] private GameObject Npcs;
    int count;
    private void Awake()
    {
        FindNpcName();
    }
    private void FindNpcName() 
    {
        count = Npcs.transform.childCount-1;
        string[] NpcNameList = new string[count];
        
        for (int i = 0; i < count; i++) 
        {
            NpcNameList[i] = Npcs.transform.GetChild(i).name;
            Debug.Log(NpcNameList[i]);
        }
    }
}
