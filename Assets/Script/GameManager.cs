using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    bool gameHasEnded = false;

    public GameObject completeLevelUI;
    public GameObject loseLevelUI;


    void Start()
    {
        Cursor.lockState = CursorLockMode.None;

        Cursor.visible = false;
    }

    public void CompleteLevel()
    {
        completeLevelUI.SetActive(true);

    }

   public  void EndGame()
    {

        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            loseLevelUI.SetActive(true);
            
        }
        
    }


    
}
