using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStart : MonoBehaviour
{

    public GlobalVars globalVars;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = true;
        PlayerPrefs.SetFloat("timePlayed", 0);
    }

    public void ResetTimePlayed()
    {
        globalVars.timePlayed = 0;
    }

}
