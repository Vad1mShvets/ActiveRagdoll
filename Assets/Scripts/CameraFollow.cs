using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Transform _objectToFollow;

    [Range(1, 25)]
    [SerializeField] private float _cameraSpeed;

    private Vector3 _offset;

    private void Awake()
    {
        _offset = transform.position;
    }

    private void FixedUpdate()
    {
        transform.position = Vector3.Lerp(transform.position, _objectToFollow.transform.position + _offset, Time.fixedDeltaTime * _cameraSpeed);
        transform.LookAt(_objectToFollow.transform.position + new Vector3(0, 6, 0));
    }
}
