using UnityEngine;

public interface IAlive
{
    void Die();
}

public class Player : MonoBehaviour, IAlive
{
    public Vector3 SpawnPoint { get; set; } 

    [SerializeField] private Joystick _joystick;

    [SerializeField] private Animator _animator;

    private ConfigurableJoint _pelvis;

    private void Awake()
    {
        SpawnPoint = transform.position + Vector3.up * 5;

        _pelvis = GetComponent<ConfigurableJoint>();
    }

    private void Update()
    {
        if (_joystick.PositionX != 0 && _joystick.PositionY != 0)
        {
            Move();
        }
        else
        {
            StopMoving();
        }

        if (transform.position.y < SpawnPoint.y - 20)
        {
            Die();
        }
    }

    private void Move()
    {
        _animator.Play("Run");
    }

    private void StopMoving()
    {
        _animator.Play("Idle");
    }

    public void Die()
    {
        transform.position = SpawnPoint;

        _pelvis.targetRotation = Quaternion.Euler(0, 0, 0);
    }
}
