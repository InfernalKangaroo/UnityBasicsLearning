using UnityEngine;
using UnityEngine.UI;

public class ProgressBar : MonoBehaviour
{
    public Player Player;
    public Transform FinishPlatform;
    public Slider Slider;
    public float AcceptableFinishPlayerDistance = 1f;

    private float _startY;
    private float _minimumreachedY;

    private void Start()
    {
        _startY = Player.transform.position.y;
    }

    private void Update()
    {
        _minimumreachedY = Mathf.Min(_minimumreachedY, Player.transform.position.y);
        float FinishY = FinishPlatform.position.y;
        float t = Mathf.InverseLerp(_startY, FinishY + AcceptableFinishPlayerDistance, _minimumreachedY);
        Slider.value = t;
    }
}
