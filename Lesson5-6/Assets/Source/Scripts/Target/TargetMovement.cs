using UnityEngine;
public class TargetMovement : MonoBehaviour
{
    private Vector3 _spawnPoint;
    [SerializeField] private Transform _target;
    private void Start()
    {
        for (int i = 0; i < 3; i++)
        {
        RandomPosition();
        Instantiate(_target, _spawnPoint, Quaternion.identity);
        }
    }
    private void RandomPosition()
    {
        float x = Random.Range(0, 10);
        float y = Random.Range(0, 10);
        float z = Random.Range(0, 10);
        _spawnPoint = new Vector3(x, y, z);
    }
}
