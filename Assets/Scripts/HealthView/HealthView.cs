using UnityEngine;

public abstract class HealthView : MonoBehaviour
{
    [SerializeField] private Health _health;

    private void OnEnable()
    {
        _health.HealthChanged += OnHealthChanged;
    }

    private void OnDisable()
    {
        _health.HealthChanged -= OnHealthChanged;
    }

    private void Start()
    {
        UpdateHealth(_health.CurrentHealth, _health.MaxHealth);
    }

    private void OnHealthChanged(float currentHealth, bool isDamage) 
    { 
        UpdateHealth(currentHealth, _health.MaxHealth);
    }

    public abstract void UpdateHealth(float currentValue, float maxValue);
}
