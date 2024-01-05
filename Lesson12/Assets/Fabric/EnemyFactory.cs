using UnityEngine;

public class EnemyFactory : MonoBehaviour
{
    [SerializeField] private Enemy _enemy;
    public void CreateMeleEnemy(Vector3 position)
    {
        Enemy enemy = Instantiate(_enemy, position, Quaternion.identity);
        enemy.SetUp(Color.yellow);
    }
    public void CreateRangeEnemy(Vector3 position)
    {
        Enemy enemy = Instantiate(_enemy, position, Quaternion.identity);
        enemy.SetUp(Color.blue);
    }
}
