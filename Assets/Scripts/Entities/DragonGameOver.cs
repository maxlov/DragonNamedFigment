using System.Collections;
using UnityEngine;
using UnityEngine.Events;

// This code does too many things for a single script
public class DragonGameOver : MonoBehaviour
{
    [SerializeField] private TimerSO timerData;
    [SerializeField] private ScoreSO scoreData;
    [SerializeField] private SceneDatabaseSO sceneDB;

    public UnityEvent gameOver = new UnityEvent();

    private void OnEnable()
    {
        timerData.outOfTime.AddListener(OnGameOver);
    }

    private void OnDisable()
    {
        timerData.outOfTime.RemoveListener(OnGameOver);
    }

    // This does NOT GO HERE but I am running out of time
    // Note: Why don't Awake() calls on SO's work so differently from monobehaviours?
    private void Awake()        
    {
        scoreData.ResetScore();
    }

    private void OnGameOver()
    {
        gameOver.Invoke();

        if (gameObject.TryGetComponent<Dragon>(out Dragon dragonMovement))
            dragonMovement.enabled = false;
        if (gameObject.TryGetComponent<WeaponInterface>(out WeaponInterface weaponInterface))
            weaponInterface.enabled = false;

        StartCoroutine(WaitCoroutine());        
    }

    // This is useful, separate into different script
    IEnumerator WaitCoroutine()
    {
        yield return new WaitForSeconds(5f);
        scoreData.UpdateHighScore();
        sceneDB.LoadGameOver();
    }
}
