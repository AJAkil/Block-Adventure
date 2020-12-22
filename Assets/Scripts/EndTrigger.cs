using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GameManager_script gameManager;

    private void OnTriggerEnter()
    {
        gameManager.CompleteLevel();
    }
}
