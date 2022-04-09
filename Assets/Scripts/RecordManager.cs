using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecordManager : MonoBehaviour
{
    public float currentRecord = 0;
    public float timePlayed = 0

    // Creating object of GlobalVars type
    public GlobalVars globalVars;

    void Start()
    {
        currentRecord = globalVars.currentReord;
        timePlayed = PlayerPrefs.get
    }

    void Update()
    {
        currentRecord += Time.deltaTime;
    }

    set NewRecord()
    {
        if (timePlayed > currentRecord)
            currentRecord = timePlayed;
    }
}
