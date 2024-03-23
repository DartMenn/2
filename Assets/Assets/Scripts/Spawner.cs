using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private PlayerController _player;
    [SerializeField] private GameObject _enemyPrefab;
    [SerializeField] private float _spawnDelay = 1.0f;

    private void Start()
    {
        _ = StartCoroutine(SpawnEnemy());
    }

    private IEnumerator SpawnEnemy()
    {
        yield return new WaitForSeconds(_spawnDelay);
        GameObject enemyObject = Instantiate(_enemyPrefab, transform.position, transform.rotation);
        EnemyAI enemyAI = enemyObject.GetComponent<EnemyAI>();
        enemyAI.InitPlayerReference(_player);
    }
}
