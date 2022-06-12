using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Clock : MonoBehaviour
{
    private const float
        secondToDegrees = 360f / 60f,
        minuteToDegrees = 360f / 60f,
        hourToDegrees = 360f / 12f;

    public Transform seconds, minutes, hours;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        DateTime time = DateTime.Now;
        TimeSpan timespan = DateTime.Now.TimeOfDay;

        seconds.localRotation = Quaternion.Euler(time.Second * secondToDegrees, 0f, 0f);
        minutes.localRotation = Quaternion.Euler((float)timespan.TotalMinutes * minuteToDegrees, 0f, 0f);
        hours.localRotation = Quaternion.Euler((float)timespan.TotalHours * hourToDegrees, 0f, 0f);

    }
}
