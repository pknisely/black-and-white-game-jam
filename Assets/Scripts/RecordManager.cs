using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecordManager : MonoBehaviour
{
    public float currentRecord = 0;
    public float timePlayed = 0;

    // Creating object of GlobalVars type
    public GlobalVars globalVars;

    void Start()
    {
        currentRecord = globalVars.currentRecord;
        timePlayed = PlayerPrefs.GetFloat("timePlayed", 0);
    }

    void Update()
    {
        currentRecord += Time.deltaTime;
    }

    void SetNewRecord()
    {
        if (timePlayed > currentRecord)
            currentRecord = timePlayed;
    }
}
