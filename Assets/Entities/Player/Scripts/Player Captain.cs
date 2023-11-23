using UnityEngine;

public class PlayerCaptain : Player
{
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            PlayerShoot();
        }
    }
}
