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
        Debug.Log(timerData.CurrentTime);
        timerData.AddTime(-Time.deltaTime);
    }
}
