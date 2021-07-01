using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreditsQuitGame : MonoBehaviour
{

    void Start()
    {
        Cursor.lockState = CursorLockMode.None;

        Cursor.visible = true;
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
