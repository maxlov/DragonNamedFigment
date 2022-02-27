using UnityEngine;
using TMPro;

[RequireComponent(typeof(TextMeshProUGUI))]
public class UpdateScoreUI : MonoBehaviour
{
    [SerializeField] private ScoreSO scoreData;
    private TextMeshProUGUI scoreUI;

    private float _currentScore;
    private float _addScore;
    private float _scoreTarget;
    private float _duration;
    private float _lerp;

    private void Awake()
    {
        scoreUI = GetComponent<TextMeshProUGUI>();
        _currentScore = scoreData.InitialScore;
    }

    private void OnEnable()
    {
        scoreData.ScoreUpdate.AddListener(OnScoreUpdate);
    }

    private void OnDisable()
    {
        scoreData.ScoreUpdate.RemoveListener(OnScoreUpdate);
    }

    private void OnScoreUpdate()
    {
        _scoreTarget = scoreData.Score;
        _addScore = _scoreTarget - _currentScore;
    }

    void Update()
    {
        scoreLerp();
    }

    private void scoreLerp()
    {
        if (_addScore > 0)
        {
            _scoreTarget = _addScore + _scoreTarget;
            _duration = _addScore / 10;
            _addScore = 0;
        }

        if (_currentScore != _scoreTarget)
        {
            _lerp += Time.deltaTime;
            _currentScore = (int)Mathf.Lerp(_currentScore, _scoreTarget, _lerp / _duration);
            if (_currentScore >= _scoreTarget - 2 && _currentScore <= _scoreTarget + 2)
            {
                _currentScore = _scoreTarget;
            }
            int intScore = (int)_currentScore;
            scoreUI.text = intScore.ToString();
        }
        else
        {
            _lerp = 0;
            // Workaround, fix lerp score to not add score several times / actually reach score faster
            scoreUI.text = ((int)scoreData.Score).ToString();
        }
    }
}
