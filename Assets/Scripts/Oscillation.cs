using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Oscillation : MonoBehaviour
{
    // public float velocidad = 0.0f;
    //public float amp = 0.0f;
    public float faseX = 0.0f;
    public float faseY = 0.0f;
    public float frecuenciaX = 0.0f;
    public float frecuenciaY = 0.0f;

    /// <summary>
    /// 
    /// </summary>

    public float voltajePlacasX = 0.0f;
    public float voltajePlacasY = 0.0f;

    public InputField inputFaseX;
    public InputField inputFaseY;
    public InputField inputFrecuenciaX;
    public InputField inputFrecuenciaY;
    public InputField inputVoltajePlacasX;
    public InputField inputVoltajePlacasY;
    public float velocidad;

    float temp = 0.0f;
    float temp1 = 0.0f;
    float temp2 = 0.0f;
    float temp3 = 0.0f;
    float tempVoltajeX = 0.0f;
    float tempVoltajeY = 0.0f;

    Vector3 PosO;


    void Start()
    {
        temp = 2.0f;
        temp1 = 2.0f;
        temp2 = 2.0f;
        temp3 = 2.0f;
        tempVoltajeX = 5.0f;
        tempVoltajeY = 6.0f;
        velocidad = 20.0f;
        PosO = transform.position;
    }

    void Update()
    {
         temp = float.Parse(inputFaseX.text);
         temp1 = float.Parse(inputFaseY.text);
         temp2 = float.Parse(inputFrecuenciaX.text);
         temp3 = float.Parse(inputFrecuenciaY.text);
         tempVoltajeX = float.Parse(inputVoltajePlacasX.text);
         tempVoltajeY = float.Parse(inputVoltajePlacasX.text);

        MovOscillation(temp, temp1, temp2, temp3, tempVoltajeX, tempVoltajeY);
    }

    public void CHANGEv(float newV)
    {
        velocidad = newV;
    }

    void MovOscillation(float newFaseX, float newFaseY, float newFrecuenciaX, float newFrecuenciaY, float newVoltajePlacasX, float newVoltajePlacasY)
    {
        float tempAx = ((0.17f * voltajePlacasX * 0.05f) / (2.0f * velocidad * 0.02f)) + ((1.0f / 4.0f) * (voltajePlacasX / 0.02f) * (0.0025f / velocidad));
        float tempAy = ((0.115f * voltajePlacasY * 0.05f) / (2.0f * velocidad * 0.05f)) + ((1.0f / 4.0f) * (voltajePlacasY / 0.05f) * (0.0025f / velocidad));

        voltajePlacasX = newVoltajePlacasX;
        voltajePlacasY = newVoltajePlacasY;

        faseX = newFaseX;
        faseY = newFaseY;
        frecuenciaX = newFrecuenciaX;
        frecuenciaY = newFrecuenciaY;
        transform.position = new Vector3(((30*tempAx) * Mathf.Cos((frecuenciaX * 1 * Time.time) + faseX)), ((30*tempAy) * Mathf.Cos((frecuenciaY * 1 * Time.time) + faseY)), 0);

    }
}