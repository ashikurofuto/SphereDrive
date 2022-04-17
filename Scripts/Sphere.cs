using UnityEngine;

public class Sphere : MonoBehaviour
{
    [SerializeField] private SphereData _sphereData;
    [SerializeField] private SphereInput _sphereInput;
    [SerializeField] private MenuPanel _menu;

    private Vector3 _sphereDirection;
    private Vector3 _startPos;
    private AddForceMoving _forceMoving;
    private IMoving _moveble;
    private Rigidbody _rigid;

    private void Awake()
    {
        _rigid = this.GetComponent<Rigidbody>();
        _forceMoving = new AddForceMoving(_rigid);
    }

    private void Start()
    {
        _moveble = _forceMoving;
        _startPos = new Vector3(13.02f, 0.31f, -1.4f);
    }

    private void OnEnable()
    {
        _menu.OnMenuOpened += ReturnStartPos;
    }

    private void OnDisable()
    {
        _menu.OnMenuOpened -= ReturnStartPos;
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
        _forceMoving.StopForce();
    }
}
