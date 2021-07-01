using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LoseLevel : MonoBehaviour
{
    public void Start()
    {

        Cursor.lockState = CursorLockMode.None;

        Cursor.visible = true;
    }

    public void reloadLevel()
    {
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);
    }
}
