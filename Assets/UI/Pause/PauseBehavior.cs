using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseBehavior : MonoBehaviour
{
    public GameObject timer;
    public Text pause_text;

    private GameObject[] player_object;

    private bool win_archive = false;

    private void Start()
    {
        player_object = GameObject.FindGameObjectsWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !timer.active)
        {
            foreach (GameObject i in player_object) // reset player already shoot
            {
                i.GetComponent<Player>().ResetPlayer();
            }

            pause_text.text = "";
            timer.SetActive(true);
            win_archive = false;
        }
    }

    public void Win(string player_name)
    {
        if (!win_archive)
        {
            pause_text.text = "Game Over!\n" + player_name + " Win!\n" + "Press Space to Restart!";
            timer.SetActive(false);
            win_archive = true;
        }
    }
}
