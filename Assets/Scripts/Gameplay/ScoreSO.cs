using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(fileName = "ScoreData", menuName = "Gameplay/ScoreSO")]
public class ScoreSO : ScriptableObject
{
    [SerializeField] private float _initialScore;
    [SerializeField] private float _currentScore;
    private float _highScore;

    [SerializeField] private TimerSO timer;

    public UnityEvent ScoreUpdate = new UnityEvent();

    public float InitialScore => _initialScore;
    public float Score => _currentScore;
    public float HighScore => _highScore;

    public void AddScore(float scoreToAdd)
    {
        _currentScore += scoreToAdd;
        
        // Later seperate to different script or add listener to score update on timer.
        if (timer != null)
            timer.AddTime(scoreToAdd / 50);
        ScoreUpdate.Invoke();
    }

    public void ResetScore()
    {
        _currentScore = 0;
    }

    public void UpdateHighScore()
    {
        if (_currentScore > _highScore)
        {
            _highScore = _currentScore;
        }
    }
}
