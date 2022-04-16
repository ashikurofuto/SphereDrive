using UnityEngine;

[CreateAssetMenu(fileName = "SphereData", menuName = "Data", order = 1)]
public class SphereData : ScriptableObject
{
    [SerializeField] private float _speed;
    public float Speed { get => _speed; }
    

}
