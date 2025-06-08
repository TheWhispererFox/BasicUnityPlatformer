using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] private TMP_Text coinsText;
    [SerializeField] private Slider healthBarSlider;

    public void UpdateCoinsText(int value) => coinsText.text = value.ToString();
    public void UpdateHealthBarSlider(float value) => healthBarSlider.value = value;
}
