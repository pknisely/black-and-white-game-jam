using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    [SerializeField] private GameObject OptionsMenu;

    public void Start()
    {
        HideOptionsMenu();
        if (SceneManager.GetActiveScene() != SceneManager.GetSceneByBuildIndex(0))
            Cursor.visible = false;
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
}
