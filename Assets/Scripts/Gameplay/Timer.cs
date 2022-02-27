using UnityEngine;

public class Timer : MonoBehaviour
{
    [SerializeField] private TimerSO timerData;

    private void Awake()
    {
        timerData.SetCurrentTime(timerData.InitialTimer);
    }

    void Update()
    {
        timerData.AddTime(-Time.deltaTime);
    }
}
