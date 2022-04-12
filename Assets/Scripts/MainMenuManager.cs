using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    [SerializeField] private GameObject OptionsMenu;
    [SerializeField] private GameObject ControlsMenu;
    [SerializeField] private GameObject DialogueBox;
    [SerializeField] private GameObject DevToolsMenu;
    [SerializeField] private GameObject RecordMenu;

    public void Start()
    {
        HideOptionsMenu();
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(2) || SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(3))
        {
            Cursor.visible = false;
        }
        else
        {
            Cursor.visible = true;
        }
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            ShowOptionsMenu();
        }
    }

    //   private OptionsMenuManager optionsMenuManager;
    public void pressStart()
    {
        SceneManager.LoadScene(1);
    }

    // Function to open the options menu
    public void ShowOptionsMenu()
    {
        Time.timeScale = 0;
        OptionsMenu.SetActive(true);
        Cursor.visible = true;
    }

    // Function to close the options menu
    public void HideOptionsMenu()
    {
        Time.timeScale = 1;
        OptionsMenu.SetActive(false);
        if (SceneManager.GetActiveScene() != SceneManager.GetSceneByBuildIndex(0))
            Cursor.visible = false;
    }

    // Function to open the options menu
    public void ShowDialogueBox()
    {
        Time.timeScale = 0;
        DialogueBox.SetActive(true);
    }

    public void HideDialogueBox()
    {
        Time.timeScale = 1;
        DialogueBox.SetActive(false);
    }

    public void CursorOn()
    {
        Cursor.visible = true;
    }

    public void CursorOff()
    {
        Cursor.visible = false;
    }

    public void ShowControlsMenu()
    {
        ControlsMenu.SetActive(true);
    }

    // Function to close the options menu
    public void HideControlsMenu()
    {
        ControlsMenu.SetActive(false);
    }

    public void ShowDevToolsMenu()
    {
        DevToolsMenu.SetActive(true);
    }

    // Function to close the options menu
    public void HideDevToolsMenu()
    {
        DevToolsMenu.SetActive(false);
    }

    public void GoMainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void GoLevel2()
    {
        SceneManager.LoadScene(2);
    }

    public void GoLevel3()
    {
        SceneManager.LoadScene(3);
    }

    public void ShowRecordMenu()
    {
        RecordMenu.SetActive(true);
    }

    // Function to close the options menu
    public void HideRecordMenu()
    {
        RecordMenu.SetActive(false);
    }
}
