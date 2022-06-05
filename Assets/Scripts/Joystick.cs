using UnityEngine;
using UnityEngine.UI;

public class Joystick : MonoBehaviour
{
    public float DeadZone;

    [HideInInspector] public float PositionX;
    [HideInInspector] public float PositionY;

    [SerializeField] private Image _joystickBorder;
    [SerializeField] private Image _joystickCenter;

    [SerializeField] private float _dragLimit;

    private void Awake()
    {
        _joystickBorder.gameObject.SetActive(false);
    }

    public void PointerDown()
    {
        _joystickBorder.gameObject.SetActive(true);

        _joystickBorder.rectTransform.position = Input.mousePosition;
        _joystickCenter.rectTransform.position = _joystickBorder.rectTransform.position;
    }

    public void PointerDrag()
    {
        Vector2 direction = Input.mousePosition - _joystickBorder.rectTransform.position;
        Vector2 normalizedDirection = direction.normalized;
        Vector2 fixedDirection = normalizedDirection * _dragLimit;

        if (fixedDirection.magnitude > DeadZone)
        {
            _joystickCenter.rectTransform.position = _joystickBorder.rectTransform.position + new Vector3(fixedDirection.x, fixedDirection.y, 0);
            PositionX = normalizedDirection.x;
            PositionY = normalizedDirection.y;
        }
    }

    public void PointerUp()
    {
        _joystickBorder.gameObject.SetActive(false);

        PositionX = 0;
        PositionY = 0;
    }
}
