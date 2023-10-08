using System.Collections;
using UnityEngine;

public class EnemySpawnController : MonoBehaviour
{
    [SerializeField] private float _spawnInterval;
    [SerializeField] private EnemyMovement _enemyMovementPrefab;
    [SerializeField] private Transform _spawnPoint1;
    [SerializeField] private Transform _spawnPoint2;

    private void Start()
    {
        StartCoroutine(SpawnEnemies());
    }

    private IEnumerator SpawnEnemies()
    {
        while (true)
        {
            Transform spawnPoint = Random.Range(0, 2) == 0 ? _spawnPoint1 : _spawnPoint2;
            EnemyMovement enemyMovement = Instantiate(_enemyMovementPrefab, spawnPoint.position, Quaternion.identity);
            enemyMovement.SetDirection(spawnPoint.up);

            yield return new WaitForSeconds(_spawnInterval);
        }
    }
}
