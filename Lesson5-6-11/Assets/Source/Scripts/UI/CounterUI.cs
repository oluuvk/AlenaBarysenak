using TMPro;
using UnityEngine;

public class CounterUI : MonoBehaviour
{
    [SerializeField] private int _count;
    [SerializeField] private TextMeshProUGUI _text;
    public void AddCount()
    {
        _count++;
        UpdateUI();
    }
    private void UpdateUI()
    {
        _text.text = $"Ты попал {_count.ToString()} раз";
    }
}
