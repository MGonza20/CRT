using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class xOscillation : MonoBehaviour
{

    public float faseX = 0.0f;
    public float frecuenciaX = 0.0f;
    public float velocidad = 0.0f;
    public float voltajePlacasX = 0.0f;

    public InputField inputFaseX;
    public InputField inputFrecuenciaX;
    public InputField inputVoltajePlacasX;

    float temp = 0.0f;
    float temp2 = 0.0f;
    float tempVoltajeX = 0.0f;


    Vector3 PosO;


    void Start()
    {
        temp = 2.0f;
        temp2 = 2.0f;
        tempVoltajeX = 5.0f;
        velocidad = 20.0f;
        PosO = transform.position;
    }

    void Update()
    {
        temp = float.Parse(inputFaseX.text);
        temp2 = float.Parse(inputFrecuenciaX.text);
        tempVoltajeX = float.Parse(inputVoltajePlacasX.text);
        MovOscillation(temp, temp2, tempVoltajeX);
    }

    
    public void CHANGEv(float newV)
    {
        velocidad = newV;
    }



    void MovOscillation(float newFaseX, float newFrecuenciaX, float newVoltajePlacasX)
    {
        // (0.17f * VoltajePlacasX * 0.05)/ (2* VoltajeAceleracion * 0.02) + 
        float tempAx = ((0.17f * voltajePlacasX * 0.05f) / (2.0f *  velocidad * 0.02f)) + ((1.0f/4.0f) * (voltajePlacasX/0.02f) * (0.0025f/velocidad)) ;

        voltajePlacasX = newVoltajePlacasX;
        faseX = newFaseX;
        frecuenciaX = newFrecuenciaX;
        //velocidad = 1.0f;
        //amplitud que depende del voltaje de x --> voltaje entre placas
        //Eje x                                                    //eje y    
        transform.position = new Vector3( ( (30*tempAx) * Mathf.Cos((frecuenciaX * 1 * Time.time) + faseX)   ) -6, 1, 0);
        //transform.position = new Vector3(((30 * tempAx) * Mathf.Cos((frecuenciaX * 1 * Time.time) + faseX)) , 1, 0);
    }

    
}