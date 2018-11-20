using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Powerup : MonoBehaviour
{
    [SerializeField]
    private float _speed = 3.0f;
    [SerializeField] // 0 = tripleShot, 1 = speedBoost, 2 = Shields
    private int _powerupID;

	void Update ()
    {
        Movement();
	}

    private void Movement()
    {
        transform.Translate(Vector3.down * _speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            Player player = other.GetComponent<Player>();
            if(player != null)
            {
                if(_powerupID == 0)
                {
                    player.TripleShotPowerUpOn();
                }
                else if(_powerupID == 1)
                {
                    player.SpeedBoostPowerupOn();
                }
                else if (_powerupID == 2)
                {
                    //player.ShieldsOn();
                }
            }

            Destroy(this.gameObject);
        }
    }
}
