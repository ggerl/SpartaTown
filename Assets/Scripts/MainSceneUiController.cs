using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MainSceneUiController : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI timeText;

    private void Update()
    {
        DateTime currentTime = DateTime.Now;

        string timeString = currentTime.ToString("HH:mm");

        timeText.text = timeString;
    }
}
