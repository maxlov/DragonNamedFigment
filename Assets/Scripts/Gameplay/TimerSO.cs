using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(fileName = "TimerData", menuName = "Gameplay/TimerSO")]
public class TimerSO : ScriptableObject
{
    [Tooltip("Time to countdown from in seconds")]
    [SerializeField] private float _initialTime;
    [SerializeField] private float _currentTime;

    public float InitialTimer => _initialTime;
    public float CurrentTime => _currentTime;

    public UnityEvent outOfTime = new UnityEvent();

    public void AddTime(float value)
    {
        _currentTime += value;

        if (_currentTime > _initialTime)
            _currentTime = _initialTime;
        
        if (_currentTime <= 0)
        {
            _currentTime = 0;
            outOfTime.Invoke();
        }
    }

    public void SetCurrentTime(float value)
    {
        _currentTime = value;
    }

    public float PercentTimeLeft()
    {
        return Mathf.Clamp01(_currentTime / _initialTime);
    }
}
