using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField]
    private GameObject _enemyShipPrefap;

    [SerializeField]
    private GameObject[] _powerups;

	void Start ()
    {
        StartCoroutine(EnemySpawnRoutine());
        StartCoroutine(PowerupSpawnRoutine());
    }
	
    IEnumerator EnemySpawnRoutine()
    {
        while(true)
        {
            Instantiate(_enemyShipPrefap, new Vector3(Random.Range(-7.5f, 7.5f), 7, 0), Quaternion.identity);
            yield return new WaitForSeconds(5.0f);
        }
    }

    IEnumerator PowerupSpawnRoutine()
    {
        while(true)
        {
            int randomPowerup = Random.Range(0, 3);
            Instantiate(_powerups[randomPowerup], new Vector3(Random.Range(-7.5f, 7.5f), 7, 0), Quaternion.identity);
            yield return new WaitForSeconds(5.0f);
        }
    }
}
