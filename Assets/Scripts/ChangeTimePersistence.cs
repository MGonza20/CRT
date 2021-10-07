using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeTimePersistence : MonoBehaviour
{
    private float time = 1.0f;
    private TrailRenderer tr;

    void Start()
    {
        tr = GetComponent<TrailRenderer>();
    }

    void Update()
    {
        tr.time = time;
    }

    public void CHANGETIME(float newTime)
    {
        time = newTime;
    }
}
