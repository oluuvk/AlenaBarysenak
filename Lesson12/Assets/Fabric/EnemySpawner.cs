using System.Collections;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private EnemyFactory _factory;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        StartCoroutine(SpawnTick1());
        if (Input.GetKeyDown(KeyCode.T))
            StartCoroutine(SpawnTick2());
    }
    private IEnumerator SpawnTick1()
    {
        yield return new WaitForSeconds(2);
        _factory.CreateMeleEnemy(transform.position + new Vector3(Random.Range(-300, 300), 0, Random.Range(-300, 300)));
    }
    private IEnumerator SpawnTick2()
    {
        yield return new WaitForSeconds(2);
        _factory.CreateRangeEnemy(transform.position + new Vector3(Random.Range(-500, 500), 0, Random.Range(-500, 500)));
    }
}
