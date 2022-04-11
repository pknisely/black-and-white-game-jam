using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class RecordManager : MonoBehaviour
{
    private float currentRecord;
    private float timePlayed;
    private float timeFinished;

    // Creating object of GlobalVars type
    public GlobalVars globalVars;

    void Start()
    {
        currentRecord = globalVars.currentRecord;
        timePlayed = PlayerPrefs.GetFloat("timePlayed", 0);
    }

    void Update()
    {
        timePlayed += Time.deltaTime;
        globalVars.timePlayed = timePlayed;
    }

    public bool SetNewRecord()
    {
        if (timeFinished < currentRecord)
        {
            currentRecord = timeFinished;
            globalVars.currentRecord = currentRecord;
            PlayerPrefs.SetFloat("currentRecord", currentRecord);
            return true;
        }
        else
            return false;
    }

    public float GetCurrentRecord()
    {
        return currentRecord;
    }

    public float GetTimeFinished()
    {
        timeFinished = timePlayed;
        return timeFinished;
    }


    public string FormatTime(float time)
    {
        //int minutes = (int)time / 60000;
        //int seconds = (int)time / 1000 - 60 * minutes;
        //int milliseconds = (int)time - minutes * 60000 - 1000 * seconds;
        var toDisplay = TimeSpan.FromSeconds(time);
        return string.Format("{0:00}:{1:00}", toDisplay.Minutes, toDisplay.Seconds);
    }

    public string DisplayCurrentTime()
    {
        return FormatTime(timePlayed);
    }

    public string DisplayCurrentRecord()
    {
        return FormatTime(currentRecord);
    }

}
