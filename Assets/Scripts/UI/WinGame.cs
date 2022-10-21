using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinGame : MonoBehaviour
{
    GameObject completeLevelUI;
    GameObject timeUI;
    Timer timer;

    void Start()
    {
        completeLevelUI = GameObject.FindWithTag("Menu");
    }

    public void CompleteGame()
    {
        timeUI = GameObject.Find("Time");
        timer = timeUI.GetComponent<Timer>();
        if (completeLevelUI == null) Debug.Log("error");
        completeLevelUI.SetActive(true);
        timeUI.SetActive(false);
        timer.pauseTime = true;
    }
}
