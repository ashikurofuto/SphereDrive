using UnityEngine;

public class AddForceMoving : IMoving
{
    private Rigidbody _rigid;

    public AddForceMoving(Rigidbody rigidbody)
    {
        _rigid = rigidbody;
    }

    public void Moving(Vector3 velocity)
    {
        _rigid.AddForce(velocity);
    }

    public void StopForce()
    {
        _rigid.Sleep();
    }

}
