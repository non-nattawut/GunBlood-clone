using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject pause_menu;
    public GameObject timer;

    public Transform gun;
    public GameObject bullet_prefab;
    private BulletBehavior bullet_behavior;

    private bool player_already_shoot = false;

    private void Start()
    {
        bullet_behavior = bullet_prefab.GetComponent<BulletBehavior>();
    }

    public void PlayerShoot(){
        float time = timer.GetComponent<TimerDisplay>().time;

        if (timer.active && time <= 0 && !player_already_shoot)
        {
            bullet_behavior.who_shoot = name;
            Instantiate(bullet_prefab, gun.position, transform.rotation);
            player_already_shoot = true;
        }
    }

    public void ResetPlayer()
    {
        player_already_shoot = false;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        string who_shoot = collision.gameObject.GetComponent<BulletBehavior>().who_shoot;
        
        PauseBehavior pause_behavior = pause_menu.GetComponent<PauseBehavior>();
        pause_behavior.Win(who_shoot);
    }
}
