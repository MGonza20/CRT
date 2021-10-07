using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineT : MonoBehaviour
{
    [SerializeField] private Transform[] points;
    [SerializeField] private line lineP;

    private void Start()
    {
        lineP.SetUpLine(points);
    }
}
