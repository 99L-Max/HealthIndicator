using UnityEngine;

public abstract class HealthView : MonoBehaviour
{
    [SerializeField] private Health _health;

    private void OnEnable()
    {
        _health.ValueChanged += OnValueChanged;
    }

    private void OnDisable()
    {
        _health.ValueChanged -= OnValueChanged;
    }

    private void Start()
    {
        UpdateHealth(_health.CurrentValue, _health.MaxValue);
    }

    private void OnValueChanged(float currentHealth, bool isDamage) 
    { 
        UpdateHealth(currentHealth, _health.MaxValue);
    }

    public abstract void UpdateHealth(float currentValue, float maxValue);
}
