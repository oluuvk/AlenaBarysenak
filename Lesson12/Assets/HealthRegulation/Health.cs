using System;
using UnityEngine;

public class Health : MonoBehaviour
{
    public Enemy enemy;
    public Action<float, float> OnHealthChange;
    public Action<Enemy> OnTakeDamage;
    [SerializeField] private float _health;
    [SerializeField] private float _maxHealth;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            HealthChange(UnityEngine.Random.Range(1, 15));
            TakeDamage();
        }
    }
    private void HealthChange(float _damage)
    {
        if (_health < 0)
            return;
        _health -=_damage;
        OnHealthChange?.Invoke(_health,_maxHealth);
    }
    private void TakeDamage()
    {
        OnTakeDamage?.Invoke(enemy);
    }
}
