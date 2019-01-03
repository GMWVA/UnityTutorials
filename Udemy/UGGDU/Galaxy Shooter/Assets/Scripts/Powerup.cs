using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Powerup : MonoBehaviour
{
    [SerializeField]
    private float _speed = 3.0f;
    [SerializeField] // 0 = tripleShot, 1 = speedBoost, 2 = Shields
    private int _powerupID;
    [SerializeField]
    private AudioClip _clip;

	void Update ()
    {
        Movement();

        if (transform.position.y < -7)
        {
            Destroy(this.gameObject);
        }
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
            AudioSource.PlayClipAtPoint(_clip, Camera.main.transform.position, 1f);
            if (player != null)
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
                    player.EnableShields();
                }
            }

            Destroy(this.gameObject);
        }
    }
}
