﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SampleTimerC : MonoBehaviour
{
    public float timeToWait = 1.0f;
    private float timeRemaining;

    // Start is called before the first frame update
    void Start()
    {
        ResetTimer();
    }

    // Update is called once per frame
    void Update()
    {
        timeRemaining -= Time.deltaTime;
        if (timeRemaining <= 0f)
        {
            Debug.Log("The Timer Has Ended!");
            ResetTimer();
        }
    }

    void ResetTimer()
    {
        timeRemaining = timeToWait;
    }
}
