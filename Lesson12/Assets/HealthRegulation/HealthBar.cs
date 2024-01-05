using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private Health health;
    [SerializeField] private Image _bar;
    private void Awake()
    {
        health.OnHealthChange += DisplayHealth;
    }
    private void DisplayHealth(float _health, float _maxHealth)
    {
        _bar.fillAmount = _health/_maxHealth;
        Debug.Log(_health);
    }
}
