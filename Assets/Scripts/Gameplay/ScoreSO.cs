using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(fileName = "ScoreData", menuName = "Gameplay/ScoreSO")]
public class ScoreSO : ScriptableObject
{
    [SerializeField] private float _initialScore;
    [SerializeField] private float _currentScore;
    

    public UnityEvent ScoreUpdate = new UnityEvent();

    public float InitialScore => _initialScore;
    public float Score => _currentScore;

    private void Awake()
    {
        _currentScore = _initialScore;
    }

    public void AddScore(float scoreToAdd)
    {
        _currentScore += scoreToAdd;
        ScoreUpdate.Invoke();
    }
}
