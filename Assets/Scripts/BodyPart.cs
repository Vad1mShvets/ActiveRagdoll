using UnityEngine;

[RequireComponent(typeof(ConfigurableJoint))]
public class BodyPart : MonoBehaviour
{
    [SerializeField] private Transform _target;

    private ConfigurableJoint _configurableJoint;

    private void Awake()
    {
        _configurableJoint = GetComponent<ConfigurableJoint>();
    }

    private void FixedUpdate()
    {
        _configurableJoint.targetRotation = Quaternion.Inverse(_target.localRotation);
    }
}
