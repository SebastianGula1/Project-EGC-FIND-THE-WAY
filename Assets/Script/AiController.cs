using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityStandardAssets.Characters.ThirdPerson;

public class AiController : MonoBehaviour
{
    public Camera cam;
    public NavMeshAgent agent;
    public ThirdPersonCharacter character;
    public GameManager gameManager;

    private void Start()
    {
        agent.updateRotation = false;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 position = GameObject.FindWithTag("Finish").transform.position;
        agent.SetDestination(position);

        if (agent.remainingDistance > agent.stoppingDistance)
        {
            character.Move(agent.desiredVelocity, false, false);
        }
        else
        {
            character.Move(Vector3.zero, false, false);
           
        }
        if (agent.transform.position==position)
        {
            FindObjectOfType<GameManager>().EndGame();

        }

    }
}
