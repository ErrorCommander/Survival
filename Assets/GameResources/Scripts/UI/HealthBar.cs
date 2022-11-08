using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private Slider _slider;
    [SerializeField] private Image _fill;
    [SerializeField] private Gradient _fillColor;

    public void Initialize()
    {
        _slider.normalizedValue = 1f;
        _fill.color = _fillColor.Evaluate(1f);
    }

    public void ChangeValue(float partHealth)
    {
        _slider.normalizedValue = partHealth;
        _fill.color = _fillColor.Evaluate(partHealth);
    }
}