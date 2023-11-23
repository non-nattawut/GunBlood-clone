using UnityEngine;

public class PlayerCanon : Player
{
    void Update()
    {
        if (Input.GetKey(KeyCode.J))
        {
            PlayerShoot();
        }
    }
}
