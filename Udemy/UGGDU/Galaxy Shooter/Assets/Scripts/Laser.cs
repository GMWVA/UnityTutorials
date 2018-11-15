using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    [SerializeField]
    private float _speed = 25.0f;

	void Start ()
    {
		
	}
	
	void Update ()
    {
        transform.Translate(Vector3.up * _speed * Time.deltaTime);

        if(transform.position.y > 5.5f)
        {
            Destroy(this.gameObject);
        }
	}
}
