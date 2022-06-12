using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ClockRotation : MonoBehaviour
{
    private const float
        sDeg = 360f / 60f,
        mDeg = 360f / 60f,
        hDeg = 360f / 12f;

    public Transform seconds, minutes, hours;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        DateTime time = DateTime.Now;

        seconds.localRotation = Quaternion.Euler(time.Second * sDeg, 0f, 0f);
        TimeSpan timespan = DateTime.Now.TimeOfDay;
        minutes.localRotation = Quaternion.Euler((float)timespan.TotalMinutes * mDeg, 0f, 0f);
        hours.localRotation = Quaternion.Euler((float)timespan.TotalHours * hDeg, 0f, 0f);
    }
}
