using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinTrigger : MonoBehaviour
{
    public WinGame winGame;

    private void OnTriggerEnter(Collider other)
    {
        winGame.CompleteGame();
    }

}
