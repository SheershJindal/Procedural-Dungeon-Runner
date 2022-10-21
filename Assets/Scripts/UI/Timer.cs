using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public float timer;

    public TextMeshProUGUI textPanel;
    public bool pauseTime = false;

    // Start is called before the first frame update
    void Start()
    {
        ResetTimer();
    }

    // Update is called once per frame
    void Update()
    {
        if (!pauseTime)
        {
            timer += Time.deltaTime;
            UpdateTimerDisplay(timer);
        }
    }

    void ResetTimer()
    {
        timer = 0f;
    }

    void UpdateTimerDisplay(float timer)
    {
        float minutes = Mathf.FloorToInt(timer / 60);
        float seconds = Mathf.FloorToInt(timer % 60);

        string currentTime = string.Format("{00:00} : {1:00}", minutes, seconds);
        textPanel.text = currentTime.ToString();
    }
}
