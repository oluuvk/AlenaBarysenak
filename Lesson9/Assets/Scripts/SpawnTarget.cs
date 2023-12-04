using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnTarget : MonoBehaviour
{
    private Vector3 _spawnPoint;
    [SerializeField] private Target _target1;
    [SerializeField] private Target _target2;
    [SerializeField] private Target _target3;
    private void Start()
    {
        Spawn(_target1);
        Spawn(_target2);
        Spawn(_target3);
    }
    private void Spawn(Target _target)
    {
        RandomPosition();
        Target targetCreated = Instantiate(_target, _spawnPoint, Quaternion.identity).GetComponent<Target>();
    }
    private void RandomPosition()
    {
        float x = Random.Range(0, 10);
        float y = Random.Range(0, 10);
        float z = Random.Range(0, 10);
        _spawnPoint = new Vector3(x, y, z);
    }
}
