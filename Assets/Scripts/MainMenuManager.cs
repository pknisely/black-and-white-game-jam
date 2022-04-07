using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    //   private OptionsMenuManager optionsMenuManager;
    public void pressStart()
    {
        SceneManager.LoadScene(1);
    }
/*
    public void pressOptions()
    {
        optionsMenuManager.openMenu;
    }
*/
}
