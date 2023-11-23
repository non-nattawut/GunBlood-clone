using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject pause_menu;
    public GameObject timer;
    public Transform gun;
    public GameObject bullet_prefab;

    private bool player_already_shoot = false;

    public void PlayerShoot(){
        float time = timer.GetComponent<TimerDisplay>().time;

        if (timer.active && time <= 0 && !player_already_shoot)
        {
            Instantiate(bullet_prefab, gun.position, transform.rotation);
            player_already_shoot = true;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        PauseBehavior pause_behavior = pause_menu.GetComponent<PauseBehavior>();
        pause_behavior.Win(name);
        player_already_shoot = false;
    }
}
