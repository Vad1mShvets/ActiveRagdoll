using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private ConfigurableJoint _pelvis;

    [SerializeField] private Joystick _joystick;

    [SerializeField] private Animator _animator;

    private void FixedUpdate()
    {
        //_pelvis.targetRotation =

        if (_joystick.PositionX > _joystick.DeadZone && _joystick.PositionY > _joystick.DeadZone)
        {
            _animator.Play("Run");
        }
        else
        {
            _animator.Play("Idle");
        }
    }
}
