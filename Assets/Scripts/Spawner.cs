using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Enemy _enemy;

    private SpawnPoint[] _spawnPoints;

    private void Start()
    {
        _spawnPoints = GetComponentsInChildren<SpawnPoint>();
        StartCoroutine(Start—reating());
    }

    private IEnumerator Start—reating()
    {
        float intervalBetweenSpawns = 2f;
        int maximumEnemy = 100;
        WaitForSeconds waitForSeconds = new WaitForSeconds(intervalBetweenSpawns);

        while (AreAnyEnemies(maximumEnemy) == false)
        {
            foreach (SpawnPoint spawnPoint in _spawnPoints)
            {
                Instantiate<Enemy>(_enemy, spawnPoint.transform.position, Quaternion.identity);

                yield return waitForSeconds;
            }
        }
    }

    private bool AreAnyEnemies(int volume)
    {
        Enemy[] enemies = FindObjectsOfType<Enemy>();

        return enemies.Length >= volume;
    }
}
