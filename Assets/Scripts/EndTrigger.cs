using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GameManager gameManager; 

    //Used for when trigger is enabled
    void OnTriggerEnter()
    {
        gameManager.CompleteLevel();

    }
}
