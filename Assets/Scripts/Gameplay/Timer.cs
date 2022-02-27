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
        if (timerData.CurrentTime == 0)
            return;
        timerData.AddTime(-Time.deltaTime);
    }
}
