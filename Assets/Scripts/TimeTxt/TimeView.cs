using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using TMPro;
using UnityEngine;

public class TimeView : MonoBehaviour
{
    private TMP_Text _timeTxt;

    private void Awake()
    {
        _timeTxt = GetComponent<TMP_Text>();
    }
    private void Update()
    {
        DateTime currentTime = DateTime.Now;
        TimeSpan time = DateTime.Now.TimeOfDay;
        _timeTxt.text = $"{time.Hours} : {time.Minutes}";
    }
}
