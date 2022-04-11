using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class RecordTextBoxManager : MonoBehaviour
{
    [SerializeField] private RecordManager recordManager;
    [SerializeField] private TMP_Text recordText;

    public void DisplayRecord()
    {
        if (recordManager.GetCurrentRecord() == 0)
        {
            recordText.text = "There is no current record";
        }
        else
        {
            string recordToDisplay = recordManager.DisplayCurrentRecord();
            recordText.text = "Current Record\n\n" + recordToDisplay;

        }

    }

}
