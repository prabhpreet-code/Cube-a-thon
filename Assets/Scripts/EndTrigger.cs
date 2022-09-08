using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    
    public GameManager gameManager;
    // Update is called once per frame
    void OnTriggerEnter()
    {
        gameManager.CompleteLevel();
    }
}
