using UnityEngine;
using UnityEngine.Events;

public class Damageable : MonoBehaviour
{
    [Header("Health")]
    [SerializeField] private HealthConfigSO _healthConfigSO;
    [SerializeField] private HealthSO _currentHealthSO;

    public UnityEvent OnDie = new UnityEvent();

	private void Awake()
	{
		//If the HealthSO hasn't been provided in the Inspector,
		//we create a new SO unique to this instance of the component. This is typical for enemies.
		if (_currentHealthSO == null)
		{
			_currentHealthSO = ScriptableObject.CreateInstance<HealthSO>();
			_currentHealthSO.SetMaxHealth(_healthConfigSO.InitialHealth);
			_currentHealthSO.SetCurrentHealth(_healthConfigSO.InitialHealth);
		}
	}

	public void ReceiveAnAttack(float damage)
	{
		_currentHealthSO.InflictDamage(damage);

		if (_currentHealthSO.CurrentHealth <= 0)
		{
			if (OnDie != null)
				OnDie.Invoke();
			_currentHealthSO.SetCurrentHealth(_healthConfigSO.InitialHealth);
			Destroy(gameObject, .1f);
		}
	}
}