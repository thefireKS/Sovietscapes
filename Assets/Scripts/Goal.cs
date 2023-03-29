using TMPro;
using UnityEngine;

public class Goal : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI countText;
    public int countToCollect;
    public Sprite objectToCollect;

    private int _currentCount;

    private void Start()
    {
        _currentCount = countToCollect;
        countText.text = _currentCount.ToString();
    }

    public void Decrease()
    {
        if (_currentCount < 0) _currentCount = 0;
        if (_currentCount > 0) _currentCount--;
        countText.text = _currentCount.ToString();
    }
}
