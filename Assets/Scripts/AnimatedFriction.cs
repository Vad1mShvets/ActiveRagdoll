using UnityEngine;

public class AnimatedFriction : MonoBehaviour
{
    [Space]
    [SerializeField] private Collider _leftFoot;
    [SerializeField] private Collider _rightFoot;

    [Space]
    [SerializeField] private PhysicMaterial _zeroFriction;
    [SerializeField] private PhysicMaterial _defaultFriction;

    public void SetFrictionRight()
    {
        _rightFoot.material = _defaultFriction;
        _leftFoot.material = _zeroFriction;
    }

    public void SetFrictionLeft()
    {
        _leftFoot.material = _defaultFriction;
        _rightFoot.material = _zeroFriction;
    }
}
