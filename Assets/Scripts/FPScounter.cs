using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FPScounter : MonoBehaviour
{
    float deltaTime = 0.0f;

    float deltaTimeSum = 0.0f;
    int frameCount = 0;
    float deltaTimeAvg = 0.0f;


    //float deltaTimeMin = float.MaxValue;
    //float deltaTimeMax = float.MinValue;

    /// <summary>
    /// It will be used for printing out fps text on screen
    /// </summary>
    TMP_Text text;

    void Start()
    {
        text = GetComponent<TMP_Text>();
    }

    void Update()
    {
        deltaTime = Time.deltaTime; //+= (Time.deltaTime - deltaTime) * 0.1f;
        deltaTimeSum += Time.deltaTime;
        frameCount++;

        deltaTimeAvg = deltaTimeSum / (float)frameCount;

        float msec = deltaTime * 1000.0f;
        float fps = 1.0f / deltaTime;

        float msecAvg = deltaTimeAvg * 1000.0f;
        float fpsAvg = 1.0f / deltaTimeAvg;




        //if (Time.realtimeSinceStartup > 10)
        //    deltaTimeMin = Mathf.Min(deltaTimeMin, deltaTime);
        //if (Time.realtimeSinceStartup > 10)
        //    deltaTimeMax = Mathf.Max(deltaTimeMax, deltaTime);


        //float fpsMin = 1.0f / deltaTimeMax;
        //float fpsMax = 1.0f / deltaTimeMin;

        // Debug.Log("dt "+ deltaTime + ", fpsavg: " + fpsAvg);

        text.text = string.Format("{0:0.0} ms - {1:0.} fps - {2:0.} fpsAvg", msec, fps, fpsAvg);
        //text.text = string.Format("{0:0.0} ms", msec) + "dt " + deltaTime + ", min: " + deltaTimeMin + ", fpsmin: " + fpsMin + ", fpsavg: " + fpsAvg;
    }
}
