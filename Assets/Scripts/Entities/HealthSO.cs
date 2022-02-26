using UnityEngine;

[CreateAssetMenu(fileName = "EntityHealth", menuName = "EntityConfig/HealthSO")]
public class HealthSO :  ScriptableObject
{
    [Tooltip("The initial health")]
    [SerializeField] private float _health;
    [SerializeField] private float _currentHealth;

    public float Health => _health;
    public float CurrentHealth => _currentHealth;

    public void SetMaxHealth(float newValue)
    {
        _health = newValue;
    }

    public void SetCurrentHealth(float newValue)
    {
        _currentHealth = newValue;
    }

    public void InflictDamage(float DamageValue)
    {
        _currentHealth -= DamageValue;
    }
}
