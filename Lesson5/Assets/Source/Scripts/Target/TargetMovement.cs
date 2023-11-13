using UnityEngine;
public class TargetMovement : MonoBehaviour
{
    [SerializeField] private Transform _spawnPoint;
    [SerializeField] private Transform _target;
    private int _force;
    private void Start()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(_target, _spawnPoint.position, Quaternion.identity);
        }
    }
}
