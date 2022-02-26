using UnityEngine;

[CreateAssetMenu(fileName = "EntityHealthConfig", menuName = "EntityConfig/HealthConfigSO")]
public class HealthConfigSO : ScriptableObject
{
	[SerializeField] private float _initialHealth;

	public float InitialHealth => _initialHealth;
}
