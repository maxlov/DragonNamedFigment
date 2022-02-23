using UnityEngine;

[CreateAssetMenu(fileName = "EntityMovement", menuName = "EntityConfig/EntityMovement")]
public class EntityMovementSO : ScriptableObject
{
    [Header("Forward Movement")]
    [SerializeField] private float _speed;
    [SerializeField] private float _speedMultiplier;
    [SerializeField] private float _baseSpeedMultiplier;
    [SerializeField] private float _boostMultiplier;
    [SerializeField] private float _brakeMultiplier;
    [Space]
    [Header("Rotational Movement")]
    [SerializeField] private float _xTorque;
    [SerializeField] private float _yTorque;

    public float Speed => _speed;
    public float SpeedMultiplier => _speedMultiplier;
    public float BaseSpeedMultiplier => _baseSpeedMultiplier;
    public float BoostMultiplier => _boostMultiplier;
    public float BrakeMultiplier => _brakeMultiplier;
    public float XTorque => _xTorque;
    public float YTorque => _yTorque;
    
    public void SetSpeed(float newValue)
    {
        _speed = newValue;
    }

    public void SetSpeedMultiplier(float newValue)
    {
        _speedMultiplier = newValue;
    }
}
