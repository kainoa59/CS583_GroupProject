using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// static class for managing time 
public static class TimeManager
{
    public static float elapsedTime = 0f;

    public static void UpdateTime()
    {
        Debug.Log(GameManager.isGameOver);
        if (GameManager.isGameOver) return;
        elapsedTime += Time.deltaTime;
    }

    public static string DisplayTime()
    {
        return TimeConversionUtils.ConvertTime(elapsedTime);
    }
}
