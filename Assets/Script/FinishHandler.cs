
using UnityEngine;


public class FinishHandler : MonoBehaviour
{

    public GameManager gameManager;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "AI")
        {
            gameManager.EndGame();
        }
        else
        {
            gameManager.CompleteLevel();
        }
        
    }
}
