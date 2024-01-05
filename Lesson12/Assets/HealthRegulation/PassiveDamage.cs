using UnityEngine;

public class PassiveDamage : MonoBehaviour
{
    [SerializeField] private Health health;
    private void Start()
    {
        health.OnTakeDamage += EnemyDamage;
    }
    private void EnemyDamage(Enemy enemy)
    {
        enemy.Die();
    }
}
