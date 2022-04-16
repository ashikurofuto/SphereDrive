using UnityEngine;

public class Sphere : MonoBehaviour
{
    [SerializeField] private SphereData _sphereData;
    [SerializeField] private SphereInput _sphereInput;

    private Vector3 _sphereDirection;
    private Vector3 _startPos;
    private AddForceMoving forceMoving;
    private IMoving _moveble;
    private Rigidbody _rigid;

    private void Awake()
    {
        _rigid = this.GetComponent<Rigidbody>();
        forceMoving = new AddForceMoving(_rigid);
    }

    private void Start()
    {
        _moveble = forceMoving;
        _startPos = transform.position;
    }

    private void OnEnable()
    {
        _sphereInput.OnMenuCalled += ReturnStartPos;
    }

    private void OnDisable()
    {
        _sphereInput.OnMenuCalled -= ReturnStartPos;
    }

    private void Update()
    {
        _sphereDirection = _sphereInput.Direction * _sphereData.Speed;
    }

    private void FixedUpdate()
    {
        _moveble.Moving(_sphereDirection);
    }

    private void ReturnStartPos()
    {
        transform.position = _startPos;
    }
}
