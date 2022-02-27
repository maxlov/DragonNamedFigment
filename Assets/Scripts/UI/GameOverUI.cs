using UnityEngine;
using TMPro;

public class GameOverUI : MonoBehaviour
{
    [SerializeField] private ScoreSO scoreData;

    [SerializeField] private GameObject gameOverCanvas;
    [SerializeField] private TextMeshProUGUI scoreUI;
    [SerializeField] private TextMeshProUGUI highScoreUI;

    [SerializeField] private GameObject victoryCanvas;


    void Awake()
    {
        if (scoreData.Score <= 0)
        {
            gameOverCanvas.SetActive(false);
            victoryCanvas.SetActive(true);
        }
        else
        {
            gameOverCanvas.SetActive(true);
            victoryCanvas.SetActive(false);
            scoreUI.text = "Score: " + ((int)scoreData.Score).ToString();
            highScoreUI.text = "High Score: " + ((int)scoreData.HighScore).ToString();
        }
    }
}
