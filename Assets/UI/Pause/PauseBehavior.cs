using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseBehavior : MonoBehaviour
{
    public GameObject timer;
    public Text pause_text;
    public Text win_text;

    private bool win_archive = false;

    private void Start()
    {
        pause_text.text = "Press Space to Go!";
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            win_text.text = "";
            pause_text.text = "";
            timer.SetActive(true);
            win_archive = false;
        }

        Debug.Log(win_archive);
    }

    public void Win(string player_name)
    {
        if (!win_archive)
        {
            win_text.text = "Game Over!\n" + player_name + " Win!";
            pause_text.text = "Press Space to Go!";
            timer.SetActive(false);
            win_archive = true;
        }
    }
}
