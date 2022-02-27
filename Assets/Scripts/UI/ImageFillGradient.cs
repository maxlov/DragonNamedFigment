using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
public class ImageFillGradient : MonoBehaviour
{
    [SerializeField] private TimerSO timerData;

    [SerializeField] private Gradient _gradient = null;
    [SerializeField] private Image _image = null;

    private void Awake()
    {
        _image = GetComponent<Image>();
    }

    private void Update()
    {
        _image.fillAmount = timerData.PercentTimeLeft();
        _image.color = _gradient.Evaluate(_image.fillAmount);
    }
}
