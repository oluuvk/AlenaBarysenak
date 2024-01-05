using System.Collections.Generic;
using UnityEngine;

public class EnemyGroup : MonoBehaviour
{
    [SerializeField] private List<Enemy> _enemies;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.J))
        {
            MoveForward();
        }
    }
    private void MoveForward()
    {
        foreach (Enemy enemy in _enemies)
        {
            enemy.Move(Vector3.forward);
        }
    }
}
