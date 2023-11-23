using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerDisplay : MonoBehaviour
{
    public GameObject timer;
    public Text timer_text;

    private float current_time = 0;
    public float time = 3;

    private void OnEnable()
    {
        ResetTimer();
    }

    private void Start()
    {
        timer.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if ( timer.active )
        {
            current_time += Time.deltaTime;
            if (current_time >= 1)
            {
                current_time = 0;
                time -= 1;
            }

            if (time >= 1)
            {
                timer_text.text = time.ToString();
            }
            else if (time == 0)
            {
                timer_text.text = "SHOOT!!!";
            }
            else if (time <= -1)
            {
                timer_text.text = "";
            }
        }

    }

    public void ResetTimer()
    {
        current_time = 0;
        time = 3;
        timer_text.text = time.ToString();
    }
}
