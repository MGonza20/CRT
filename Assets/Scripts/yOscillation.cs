using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class yOscillation : MonoBehaviour
{

    public float faseY = 0.0f;
    public float frecuenciaY = 0.0f;
    public float velocidad = 0.0f;
    public float voltajePlacasY = 0.0f;

    public InputField inputFaseY;
    public InputField inputFrecuenciaY;
    public InputField inputVoltajePlacasY;

    float temp = 0.0f;
    float temp2 = 0.0f;
    float tempVoltajeY = 0.0f;




    Vector3 PosO;


    void Start()
    {
        temp = 2.0f;
        temp2 = 2.0f;
        tempVoltajeY = 6.0f;
        velocidad = 20.0f;
        PosO = transform.position;
    }

    void Update()
    {
        temp = float.Parse(inputFaseY.text);
        temp2 = float.Parse(inputFrecuenciaY.text);
        tempVoltajeY = float.Parse(inputVoltajePlacasY.text);


        MovOscillation(temp, temp2, tempVoltajeY);
    }

    public void CHANGEv(float newV)
    {
        velocidad = newV;
    }

    void MovOscillation(float newFaseX, float newFrecuenciaX, float newVoltajePlacasY)
    {
        float tempAy = ((0.115f * voltajePlacasY * 0.05f) / (2.0f * velocidad * 0.05f)) + ((1.0f / 4.0f) * (voltajePlacasY / 0.05f) * (0.0025f / velocidad));

        voltajePlacasY = newVoltajePlacasY;

        faseY = newFaseX;
        frecuenciaY = newFrecuenciaX;

        transform.position = new Vector3(4, ((50*tempAy) * Mathf.Cos((frecuenciaY * Time.time) + faseY)), 0);


    }
}